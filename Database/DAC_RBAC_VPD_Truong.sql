
-- tạo ADMIN
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
/
--Tao user dba QLTGDA (SYS)
CREATE USER QLTGDA IDENTIFIED BY admin;
GRANT ALL PRIVILEGES TO QLTGDA WITH ADMIN OPTION;



GRANT DBA TO QLTGDA;
GRANT CREATE ROLE TO QLTGDA WITH ADMIN OPTION;
GRANT ALTER USER TO QLTGDA WITH ADMIN OPTION;
GRANT CREATE USER TO QLTGDA WITH ADMIN OPTION;
GRANT ALTER ANY ROLE TO QLTGDA WITH ADMIN OPTION;
GRANT DROP USER TO QLTGDA WITH ADMIN OPTION;
GRANT DROP ANY ROLE TO QLTGDA WITH ADMIN OPTION;
GRANT SELECT ANY DICTIONARY TO QLTGDA WITH ADMIN OPTION;
GRANT CREATE ANY VIEW TO QLTGDA WITH ADMIN OPTION;


GRANT EXECUTE ON DBMS_RLS TO QLTGDA;
GRANT EXECUTE ON DBMS_CRYPTO TO QLTGDA;
GRANT EXECUTE ON dbms_fga TO QLTGDA;
GRANT UNLIMITED TABLESPACE TO QLTGDA;
GRANT CREATE SESSION TO QLTGDA;
/
--Cap quyen vao bang DBMS_CRYPTO de cai dat ma hoa
GRANT EXECUTE ON SYS.DBMS_CRYPTO TO QLTGDA;
/
--Cap quyen doc audit_trail
GRANT SELECT ON DBA_AUDIT_TRAIL TO QLTGDA;
/
-- tao role
create role SYSADMIN;
GRANT SYSADMIN TO QLTGDA;

CREATE ROLE NHANVIEN;
/
CREATE ROLE QLTRUCTIEP;
/
CREATE ROLE TRUONGPHONG;
/
CREATE ROLE TAICHINH;
/
CREATE ROLE NHANSU;
/
CREATE ROLE TRUONGDA;

--CS#1: NHAN VIEN 
/
GRANT SELECT ON DBA_ROLE_PRIVS TO NHANVIEN; 
/
GRANT UPDATE(TENNV,DIACHI,NGAYSINH,SODT) ON NHANVIEN TO NHANVIEN;
/
CREATE OR REPLACE VIEW VIEW_NHANVIEN_XEMTHONGTIN_CANHAN
AS
    SELECT *
    FROM NHANVIEN
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
CREATE OR REPLACE VIEW VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN
AS
    SELECT * 
    FROM PHONGBAN
/
CREATE OR REPLACE VIEW VIEW_NHANVIEN_XEM_THONGTIN_DEAN
AS
    SELECT * 
    FROM DEAN
/
CREATE OR REPLACE VIEW VIEW_TRUONGPHONG_THAOTAC_PHANCONG
 AS
    SELECT PC.* FROM NHANVIEN NV 
    JOIN PHANCONG PC ON NV.MANV = PC.MANV
    WHERE PHG IN (SELECT PHG FROM NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'));
/

--GRANT QUYEN ROLE NHANVIEN
GRANT EXECUTE ON UPDATE_PROFILE TO  NHANVIEN;
/
GRANT SELECT, UPDATE (NGAYSINH,DIACHI,SODT) ON VIEW_NHANVIEN_XEMTHONGTIN_CANHAN TO NHANVIEN;
/
GRANT SELECT ON VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN TO NHANVIEN;
/
GRANT SELECT ON VIEW_NHANVIEN_XEM_THONGTIN_DEAN TO NHANVIEN;
/
GRANT SELECT ON PHANCONG TO NHANVIEN; --(CAN CAI DAT VPD_1) 

--VPD 1: Nhân viên có quy�?n xem tất cả các thuộc tính trên quan hệ PHANCONG liên quan đến chính nhân viên đó.

CREATE OR REPLACE FUNCTION THONGTIN_PHANCONG
    (schema_name IN VARCHAR2, table_name IN VARCHAR2)
    RETURN VARCHAR2
IS
    predicate VARCHAR2(4000);
BEGIN
    predicate :=
        'EXISTS (
            SELECT 1
            FROM NHANVIEN, PHANCONG
            WHERE
                (
                    VAITRO = ''Nhân viên'' AND MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')
                )
                OR
                (
                    VAITRO = ''QL trực tiếp'' OR (MANQL = (SELECT MANV FROM NHANVIEN WHERE MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')) AND (MANV = :MANV OR EXISTS (SELECT 1 FROM PHANCONG WHERE MANV = :MANV )))
                )
        )';

    RETURN predicate;
END;
/


BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTGDA',
        object_name     => 'PHANCONG',
        policy_name     => 'VPD_THONGTIN_PHANCONG_POLICY',
        function_schema => 'QLTGDA',
        policy_function => 'THONGTIN_PHANCONG',
        statement_types => 'SELECT',
        enable          => TRUE
    );
END;
/




--CS#2: QL TRUC TIEP
/
GRANT NHANVIEN TO TRUONGPHONG;
/
GRANT SELECT ON NHANVIEN TO QLTRUCTIEP; --(CAN CAI DAT VPD_2)

--VPD_ 2: QL TRUC TIEP CO THE XEM CAC THUOC TINH CUA NHAN VIEN MA MINH QUAN LY (NGOAI TRU LUONG VA PHUCAP)
CREATE OR REPLACE FUNCTION DSNHANVIEN_VPD_POLICY
    (schema_name IN VARCHAR2, table_name IN VARCHAR2)
    RETURN VARCHAR2
IS
    predicate VARCHAR2(4000);
BEGIN
    predicate :=
        'EXISTS (
            SELECT 1
            FROM NHANVIEN, PHONGBAN
            WHERE
			(
                VAITRO = ''Trưởng phòng'' AND MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER'') AND NHANVIEN.PHG = PHONGBAN.MAPB AND NHANVIEN.MANV = PHONGBAN.TRPHG
			)
			OR
			(
				VAITRO = ''QL trực tiếp'' OR (MANQL = (SELECT MANV FROM NHANVIEN WHERE MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER''))
			)
        )';

    RETURN 'NOT (column_name = ''LUONG'' OR column_name = ''PHUCAP'') OR (' || predicate || ')';
END;
/




BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTGDA',
        object_name     => 'NHANVIEN',
        policy_name     => 'VPD_DSNHANVIEN_POLICY',
        function_schema => 'QLTGDA',
        policy_function => 'DSNHANVIEN_VPD_POLICY',
        statement_types => 'SELECT',
        update_check    => FALSE,
        enable          => TRUE
    );
END;

-- QUAN LY TRUC TIEP có thể xem các dòng trong quan hệ PHANCONG liên quan đến chính h�? và các nhân viên được h�? quản lý trực tiếp
 --GRANT SELECT ON PHANCONG TO QLTRUCTIEP;(đã kế thừa từ NHANVIEN) --(CAN CAI DAT VPD_1)
 -- DUNG VPD VPD_THONGTIN_PHANCONG_POLICY DA CAI DAT O TREN
/



--CS#3: TRUONG PHONG
/
CREATE OR REPLACE VIEW VIEW_TRUONGPHONG_THONGTIN_PHANCONG 
AS
    SELECT PC.*
    FROM NHANVIEN NV 
    JOIN PHANCONG PC ON NV.MANV = PC.MANV
    WHERE PHG IN (SELECT PHG FROM NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'));

/
GRANT NHANVIEN TO TRUONGPHONG; 
/
GRANT SELECT, UPDATE, DELETE ON VIEW_TRUONGPHONG_THONGTIN_PHANCONG TO TRUONGPHONG;
/
GRANT SELECT ON NHANVIEN TO TRUONGPHONG; --(CAN CAI DAT VPD_2)
/
-- TRUONG PHONG CO THE XEM CAC THUOC TINH CUA NHAN VIEN PHONG MINH (NGOAI TRU LUONG VA PHUCAP)
 -- DUNG VPD_DSNHANVIEN_POLICY DA CAI DAT O TREN
/*
CREATE OR REPLACE FUNCTION DSNHANVIEN_VPD_POLICY
    (schema_name IN VARCHAR2, table_name IN VARCHAR2)
    RETURN VARCHAR2
IS
    predicate VARCHAR2(4000);
BEGIN
    predicate :=
        'EXISTS (
            SELECT 1
            FROM NHANVIEN, PHONGBAN
            WHERE
			(
                VAITRO = ''Trưởng phòng'' AND MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER'') AND NHANVIEN.PHG = PHONGBAN.MAPB AND NHANVIEN.MANV = PHONGBAN.TRPHG
			)
			OR
			(
				VAITRO = ''QL trực tiếp'' OR (MANQL = (SELECT MANV FROM NHANVIEN WHERE MANV = SYS_CONTEXT(''USERENV'',''SESSION_USER''))
			)
        )';

    RETURN 'NOT (column_name = ''LUONG'' OR column_name = ''PHUCAP'') OR (' || predicate || ')';
END;
/




BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTGDA',
        object_name     => 'NHANVIEN',
        policy_name     => 'VPD_DSNHANVIEN_POLICY',
        function_schema => 'QLTGDA',
        policy_function => 'DSNHANVIEN_VPD_POLICY',
        statement_types => 'SELECT',
        update_check    => FALSE,
        enable          => TRUE
    );
END;
*/

/
--CS#4: TAI CHINH
GRANT NHANVIEN TO TAICHINH; 
  -- TẠO TRIGGER XỬ L�? CHỔ CHỈ UPDATE LUONG NV - GIAM DOC
/

--CS#5: NhanSu

GRANT NHANVIEN TO NHANSU;
/
GRANT INSERT, UPDATE ON PHONGBAN TO NHANSU;
/   
GRANT UPDATE (MANV,TENNV,PHAI,NGAYSINH,DIACHI,SODT,VAITRO,MANQL,PHG) ON NHANVIEN TO NHANSU;
    -- cài đặt proc để insert, update The Nhan vien với lương và phụ cấp có gt là NULL 
-- CAI VPD: Nhan Su không được xem LUONG, PHUCAP của ngư�?i khác và không được cập nhật trên các trư�?ng LUONG, PHUCAP.


CREATE OR REPLACE FUNCTION NHANSU_VPD_POLICY
    (schema_name IN VARCHAR2, table_name IN VARCHAR2)
    RETURN VARCHAR2
IS
    predicate VARCHAR2(4000);
BEGIN
     predicate := 'VAITRO <> ''Nhân sự'' OR (VAITRO = ''Nhân sự'' AND SYS_CONTEXT(''USERENV'',''SESSION_USER'') = MANV)';

    RETURN 'CASE
                WHEN column_name IN (''LUONG'', ''PHUCAP'') THEN NULL
                ELSE ' || predicate || '
            END';
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTGDA',
        object_name     => 'NHANVIEN',
        policy_name     => 'VPD_NHANSU_POLICY',
        function_schema => 'QLTGDA',
        policy_function => 'NHANSU_VPD_POLICY',
        statement_types => 'SELECT, UPDATE',
        update_check    => TRUE,
        enable          => TRUE
    );
END;
/





--CS#6: TRUONG DE AN
CREATE OR REPLACE VIEW VIEW_HIENTHI_ALL_DEAN
AS  
    SELECT * FROM DEAN;
/
GRANT NHANVIEN TO TRUONGDA;
/
GRANT INSERT, UPDATE, DELETE ON VIEW_HIENTHI_ALL_DEAN TO TRUONGDA;



--CS#7: GIAM DOC ( KO CAI DAT )



