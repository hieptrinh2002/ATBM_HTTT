/*===================================================================================================================*/
-- Connect as SYS
ALTER SESSION SET CONTAINER = CDB$ROOT;
/
-- Tạo PLUGGABLE DATABASE
CREATE PLUGGABLE DATABASE PDB_QLTGDA                                                                                    
ADMIN USER DBA_QLTGDA  IDENTIFIED BY "123" ROLES = (dba)
FILE_NAME_CONVERT = ('pdbseed', 'PDB_QLTGDA');

ALTER SESSION SET CONTAINER = PDB_QLTGDA;
ALTER PLUGGABLE DATABASE PDB_QLTGDA OPEN;
ALTER USER DBA_QLTGDA QUOTA UNLIMITED ON SYSTEM;
/
--Bật OLS
SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';  -- Nếu trả về FALSE thì thực hiện EXEC LBACSYS.CONFIGURE_OLS
EXEC LBACSYS.CONFIGURE_OLS;
/
SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Oracle Label Security'; -- Nếu trả về FALSE thì thực hiện LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
/
-- Unlock LBACSYS
ALTER USER LBACSYS IDENTIFIED BY "123" ACCOUNT UNLOCK;
SELECT ACCOUNT_STATUS FROM DBA_USERS WHERE USERNAME = 'LBACSYS'; -- Kiểm tra trạng thái đã OPEN hay chưa
GRANT CONNECT TO LBACSYS;
/
SHUTDOWN IMMEDIATE
STARTUP

-- Kiểm tra OLS đã được kích hoạt trong Oracle hay chưa
SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Oracle Label Security';
/

/*===================================================================================================================*/
-- Tạo chính sách
CONN LBACSYS/123;
ALTER SESSION SET CONTAINER = PDB_QLTGDA;
/
BEGIN
    SA_SYSDBA.DROP_POLICY (
        policy_name => 'XEM_THONG_BAO',
        drop_column => true  -- Xóa t?t c? các c?t có liên quan ??n chính sách
    );
END;
/
BEGIN
    SA_SYSDBA.CREATE_POLICY (
        policy_name => 'XEM_THONG_BAO',
        column_name => 'OLS_COLUMN'
    );  
END;
/
-- Gán quyền truy cập cho user DBA_QLTGDA 
GRANT EXECUTE ON SA_COMPONENTS TO DBA_QLTGDA;
GRANT EXECUTE ON SA_USER_ADMIN TO DBA_QLTGDA;
GRANT EXECUTE ON SA_LABEL_ADMIN TO DBA_QLTGDA;
GRANT EXECUTE ON SA_POLICY_ADMIN TO DBA_QLTGDA;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO DBA_QLTGDA;
GRANT EXECUTE ON SA_SYSDBA TO DBA_QLTGDA;
/

/*===================================================================================================================*/
CONN DBA_QLTGDA/123@//LOCALHOST:1521/PDB_QLTGDA;
GRANT INHERIT PRIVILEGES ON USER DBA_QLTGDA TO LBACSYS;
-- Tạo bảng THONGBAO
--DROP TABLE THONGBAO
CREATE TABLE THONGBAO (
    MATB VARCHAR(5) NOT NULL,
    NOIDUNG NVARCHAR2(300),
	CAPBAC NVARCHAR2(100), 
	LINHVUC NVARCHAR2(100),
	CHINHANH NVARCHAR2(100),
    NGAYTB DATE,
    PRIMARY KEY (MATB)
);
/

INSERT INTO THONGBAO (MATB, NOIDUNG, CAPBAC, LINHVUC, CHINHANH, NGAYTB) VALUES ('TB1', N'Thông báo t1 đến tất cả trưởng phòng phụ trách tất cả các lĩnh vực không phân biệt chi nhánh.',  N'Trưởng phòng',  N'Mua bán, Sản xuất, Gia công', null, TO_DATE('2023-06-15', 'YYYY-MM-DD'));
INSERT INTO THONGBAO (MATB, NOIDUNG, CAPBAC, LINHVUC, CHINHANH, NGAYTB) VALUES ('TB2', N'Thông báo t2 đến trưởng phòng phụ trách lĩnh vực sản xuất ở miền Trung.', N'Trưởng phòng', N'Sản xuất', N'Miền Trung', TO_DATE('2023-06-16', 'YYYY-MM-DD'));
INSERT INTO THONGBAO (MATB, NOIDUNG, CAPBAC, LINHVUC, CHINHANH, NGAYTB) VALUES ('TB3', N'Thông báo t3 đến nhân viên phụ trách lĩnh vực gia công ở miền Nam', N'Nhân viên', N'Gia công', N'Miền Nam', TO_DATE('2023-06-17', 'YYYY-MM-DD'));

-- Tạo user
CREATE USER TONGGIAMDOC identified by "123";
CREATE USER TRUONGPHONG_SANXUAT_MIENNAM identified by "123";
CREATE USER GIAMDOC_MIENBAC identified by "123";
/
-- Gán quyền cho user
GRANT SELECT ON THONGBAO TO TONGGIAMDOC;
GRANT SELECT ON THONGBAO TO TRUONGPHONG_SANXUAT_MIENNAM;
GRANT SELECT ON THONGBAO TO GIAMDOC_MIENBAC;
GRANT CREATE SESSION TO TONGGIAMDOC, TRUONGPHONG_SANXUAT_MIENNAM, GIAMDOC_MIENBAC;

CONN DBA_QLTGDA/123@//LOCALHOST:1521/PDB_QLTGDA;
SELECT * FROM THONGBAO;


/*============================================================================*/
-- Tạo LABEL
-- LEVEL
CONN LBACSYS/123;
ALTER SESSION SET CONTAINER = PDB_QLTGDA;
BEGIN
    sa_components.create_level (
        policy_name => 'XEM_THONG_BAO',
        long_name   => 'GIAM_DOC',
        short_name  => 'GD',
        level_num   => 9000
    );
END;
/
BEGIN
    sa_components.create_level (
        policy_name => 'XEM_THONG_BAO',
        long_name   => 'TRUONG_PHONG',
        short_name  => 'TP',
        level_num   => 7000
    );
END;
/

BEGIN
    sa_components.create_level (
        policy_name => 'XEM_THONG_BAO',
        long_name   => 'NHAN_VIEN',
        short_name  => 'NV',
        level_num   => 4000
    );
END;
/

-- COMPARTMENT
BEGIN
     sa_components.create_compartment (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'MUA_BAN',
        short_name => 'MB',
        comp_num => 1000
    );
END;
/
BEGIN
     sa_components.create_compartment (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'SAN_XUAT',
        short_name => 'SX',
        comp_num => 2000
    );
END;
/
BEGIN
     sa_components.create_compartment (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'GIA_CONG',
        short_name => 'GC',
        comp_num => 3000
    );
END;


-- GROUP 
BEGIN
     sa_components.create_GROUP (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'MIEN_BAC',
        short_name => 'MB',
        GROUP_num => 1000
    );
END;
/
BEGIN
     sa_components.create_GROUP (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'MIEN_TRUNG',
        short_name => 'MT',
        GROUP_num => 2000
    );
END;
/
BEGIN
     sa_components.create_GROUP (
        policy_name => 'XEM_THONG_BAO',
        long_name =>'MIEN_NAM',
        short_name => 'MN',
        GROUP_num => 3000
    );
END;
/

/*===========================================================================*/
CONN DBA_QLTGDA/123@//LOCALHOST:1521/PDB_QLTGDA;
-- Hàm gán label
CREATE OR REPLACE FUNCTION DBA_QLTGDA.GAN_NHAN_THONGBAO
 (CAPBAC NVARCHAR2, LINHVUC NVARCHAR2, CHINHANH NVARCHAR2)
RETURN LBACSYS.LBAC_LABEL
AS
 i_label varchar2(80);
BEGIN
--------- Xác ??nh level
IF CAPBAC = N'Giám đốc' THEN
    i_label := 'GD:';
ELSIF CAPBAC = N'Trưởng phòng' THEN
    i_label := 'TP:';
ELSE
    i_label := 'NV:';
END IF;

--------- Xác định compartment 
IF LINHVUC LIKE N'%Mua bán%' THEN
    i_label := i_label||'MB,';
END IF;
IF LINHVUC LIKE N'%Sản xuất%' THEN
    i_label := i_label||'SX,';
END IF;
IF LINHVUC LIKE N'%Gia công%' THEN
    i_label := i_label||'GC,';
END IF;
i_label := i_label||':';

--------- Xác định group
IF CHINHANH LIKE N'%Miền Bắc%' THEN
    i_label := i_label||'MB,';
END IF;
IF CHINHANH LIKE N'%Miền Trung%' THEN
    i_label := i_label||'MT,';
END IF;
IF CHINHANH LIKE N'%Miền Nam%' THEN
    i_label := i_label||'MN,';
END IF;

RETURN TO_LBAC_DATA_LABEL('XEM_THONG_BAO',i_label);
END;
/

GRANT EXECUTE ON DBA_QLTGDA.GAN_NHAN_THONGBAO TO LBACSYS;

/*===========================================================================*/
CONN LBACSYS/123;
ALTER SESSION SET CONTAINER = PDB_QLTGDA;
--Gán label lên dữ liệu
BEGIN
    sa_policy_admin.remove_table_policy (
        policy_name     => 'XEM_THONG_BAO',
        schema_name     => 'DBA_QLTGDA',
        table_name      => 'THONGBAO'
    );
END;
/
BEGIN
    sa_policy_admin.apply_table_policy (
        policy_name     => 'XEM_THONG_BAO',
        schema_name     => 'DBA_QLTGDA',
        table_name      => 'THONGBAO',
        table_options   => 'HIDE,READ_CONTROL',
        label_function => 'DBA_QLTGDA.GAN_NHAN_THONGBAO(:new.capbac, :new.linhvuc, :new.chinhanh)',
        PREDICATE => NULL);
END;
/

--Gán label lên user
BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'XEM_THONG_BAO',
        user_name       => 'TONGGIAMDOC',
        max_read_label  => 'GD:MB,SX,GC:MB,MT,MN'
    );
END;
/

BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'XEM_THONG_BAO',
        user_name       => 'TRUONGPHONG_SANXUAT_MIENNAM',
        max_read_label  => 'TP:SX:MN'
    );
END;
/

BEGIN
    sa_user_admin.set_user_labels (
        policy_name     => 'XEM_THONG_BAO',
        user_name       => 'GIAMDOC_MIENBAC',
        max_read_label  => 'GD:MB,SX,GC:MB'
    );
END;
/

