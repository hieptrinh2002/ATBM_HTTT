-- Dang nhap bang QLTGDA va chay lan luot cac cau lenh sau
alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;





--FINE-GRAINED AUDITING
--Hãy cho biết cụ thể cách thức ghi vết (audit) các hành vi sau:
--a. Những người đã cập nhật trường THOIGIAN trong quan hệ PHANCONG.

/
BEGIN
    DBMS_FGA.DROP_POLICY(
        object_schema   =>  'QLTGDA',
        object_name     =>  'PHANCONG',
        policy_name     =>  'AUDIT_UPDATE_THOIGIAN_PHANCONG');
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'QLTGDA',
   object_name        => 'PHANCONG',
   policy_name        => 'AUDIT_UPDATE_THOIGIAN_PHANCONG',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'THOIGIAN',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/
--b. Những người đã đọc trên trường LUONG và PHUCAP của người khác.
BEGIN
    DBMS_FGA.DROP_POLICY(
        object_schema   =>  'QLTGDA',
        object_name     =>  'NHANVIEN',
        policy_name     =>  'AUDIT_XEM_LUONG_PHUCAP_ON_NHANVIEN');
END;
/
BEGIN
    DBMS_FGA.ADD_POLICY(
        object_schema   =>  'QLTGDA',
        object_name     =>  'NHANVIEN',
        policy_name     =>  'AUDIT_XEM_LUONG_PHUCAP_ON_NHANVIEN',
        enable          =>   TRUE,
        statement_types =>  'SELECT',
        audit_column    =>  'LUONG, PHUCAP',
        audit_condition => 'MANV != SYS_CONTEXT(''USERENV'',''SESSION_USER'')',
        audit_trail     =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
--c. Một người không thuộc vai trò “Tài chính” nhưng đã cập nhật thành công trên trường LUONG và PHUCAP.
/
BEGIN
    DBMS_FGA.DROP_POLICY(
        object_schema   =>  'QLTGDA',
        object_name     =>  'NHANVIEN',
        policy_name     =>  'AUDIT_UPDATE_LUONG_PHUCAP_KHONG_PHAI_TAICHINH');
END;
/
BEGIN
    dbms_fga.ADD_POLICY (
        OBJECT_SCHEMA => 'QLTGDA',
        OBJECT_NAME => 'NHANVIEN',
        POLICY_NAME => 'AUDIT_UPDATE_LUONG_PHUCAP_KHONG_PHAI_TAICHINH',
        AUDIT_COLUMN => 'LUONG, PHUCAP',
        AUDIT_CONDITION => ' VAITRO != ''Tài chính'')',
        STATEMENT_TYPES => 'UPDATE',
        ENABLE => TRUE,
        audit_trail     =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/
-- Kiểm tra nhật ký hệ thống.

SELECT DB_USER,OBJECT_SCHEMA,POLICY_NAME,SQL_TEXT,STATEMENT_TYPE FROM DBA_FGA_AUDIT_TRAIL;

/


UPDATE QLTGDA.NHANVIEN SET LUONG = '1000400' WHERE MANV ='NV001' AND 



-- Audit Standard

-- Theo doi hanh vi cua cac user tren tat ca cac table
/
AUDIT ALL ON QLTGDA.NHANVIEN BY ACCESS;
AUDIT ALL ON QLTGDA.PHANCONG BY ACCESS;
AUDIT ALL ON QLTGDA.DEAN BY ACCESS;
AUDIT ALL ON QLTGDA.PHONGBAN BY ACCESS;

-- Theo doi cac hanh vi thanh cong
AUDIT ALL WHENEVER SUCCESSFUL;

-- Theo doi cac hanh vi khong thanh cong
AUDIT ALL WHENEVER NOT SUCCESSFUL;

--------------------AUDIT TESTING--------------------
--B1: dang nhap bang user NV va chay cau lenh sau:
SELECT * FROM QLTGDA.NHANVIEN;

-- B2: dang nhap bang quanly, chay cau lenh sau de xem ket qua audit:
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text 
from dba_audit_trail
WHERE OBJ_NAME = 'NHANVIEN';




SELECT * FROM SYS.FGA_LOG$ order by NTIMESTAMP# desc;



