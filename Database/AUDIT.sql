-- SQL PLUS commands
-- Connect as SYS on CDB$ROOT first
-- prior to executing these commands
ALTER SYSTEM SET audit_trail=db,extended SCOPE=spfile;
SHUTDOWN IMMEDIATE;
STARTUP;
/

-- Check audit option
--select * from v$parameter where name like '%trail%';

-- Connect as SYS on pluggable database first
-- prior to executing the following commands

-- Enable audit on tables
AUDIT UPDATE ON PHANCONG;
AUDIT SELECT ON NHANVIEN;
AUDIT UPDATE ON NHANVIEN;
/

-- 4a
SELECT *
FROM DBA_AUDIT_TRAIL
WHERE OBJ_NAME = 'PHANCONG'
    AND SQL_TEXT LIKE '%THOIGIAN%'
    AND ACTION_NAME = 'UPDATE';
/
  
-- 4b
SELECT *
FROM DBA_AUDIT_TRAIL
WHERE OBJ_NAME = 'NHANVIEN'
    AND SQL_TEXT LIKE '%LUONG%'
    AND SQL_TEXT LIKE '%PHUCAP%';
/
    
-- 4c
SELECT *
FROM DBA_AUDIT_TRAIL
WHERE ACTION_NAME = 'UPDATE'
    AND OBJ_NAME = 'NHANVIEN'
    AND (USERNAME NOT IN (
            SELECT GRANTEE
            FROM DBA_ROLE_PRIVS
            WHERE GRANTED_ROLE = 'TAICHINH'
        ) OR USERNAME IS NULL)
    AND SQL_TEXT LIKE '%LUONG%'
    AND SQL_TEXT LIKE '%PHUCAP%';
/
