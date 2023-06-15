-- tạo ADMIN
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--Tao user dba QLTGDA (SYS)
CREATE USER QLTGDA IDENTIFIED BY admin;
GRANT ALL PRIVILEGES TO QLTGDA;
GRANT DBA TO QLTGDA;

--Cap quyen vao bang DBMS_CRYPTO de cai dat ma hoa
GRANT EXECUTE ON SYS.DBMS_CRYPTO TO QLTGDA;


--Cap quyen doc audit_trail
GRANT SELECT ON DBA_AUDIT_TRAIL TO QLTGDA;





----- Tao moi user
create or replace procedure proc_CREATE_NewUser(User_name in varchar2,Pass_Word in varchar2)
authid current_user 
as
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        RAISE_APPLICATION_ERROR(-20000,'User da ton tai'); 
    ELSE 
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
        execute immediate('Create user '|| User_name||' identified by '||Pass_Word);
        execute immediate('grant create session to '||User_name);
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');

    END IF;
End;

-------update user (passwword)
create or replace procedure proc_Change_UserPassword(User_name in varchar2,New_PassWord in varchar2)
authid current_user
is
Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        execute immediate('alter user '|| User_name||' identified by '||New_PassWord);
    ELSE 
            RAISE_APPLICATION_ERROR(-20000,'User khong ton tai'); 
    END IF;
END;
/

-- x�a USER
create or replace procedure Proc_DROP_User(User_name in varchar2)
authid current_user 
as
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
        execute immediate('DROP USER '|| User_name);
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');
    ELSE 
         RAISE_APPLICATION_ERROR(-20000,'User khong ton tai'); 
    END IF;
End;

create or replace procedure Proc_DROP_User_CASCADE (User_name in varchar2)
authid current_user 
as
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
        execute immediate('DROP USER '|| User_name||' CASCADE');
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');
    ELSE 
         RAISE_APPLICATION_ERROR(-20000,'User khong ton tai'); 
    END IF;
End;
exec Proc_DROP_User('NV333')

------Tao role
create or replace procedure Proc_Create_NewRole(Role_name in varchar2,Pass_Word in varchar2)
authid current_user 
as
    Tmp_query varchar(100);
Begin
    execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    IF(Pass_Word != '' or Pass_Word != ' ') THEN
    Tmp_query := 'Create role '|| Role_name||' identified by '||Pass_Word;
    ELSE
    Tmp_query := 'Create role '|| Role_name;
    END IF;
    execute IMMEDIATE (Tmp_query);
    execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');
End;

------Xoa role
create or replace procedure Proc_Drop_Role(Role_name in varchar2)
authid current_user 
as
    Tmp_query varchar(100);
Begin
    execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    Tmp_query := 'Drop role '|| Role_name;
    execute IMMEDIATE (Tmp_query);
    execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');
End;
/

------update role
create or replace procedure Proc_Update_RolePwd(Role_name in varchar2,new_Pwd in varchar2)
authid current_user
is
    Tmp_query varchar2(100);
begin
    if(new_Pwd=' ' or new_Pwd='') then
    Tmp_query :='ALTER ROLE '|| Role_Name|| ' Not IDENTIFIED';
    execute immediate(Tmp_query);
    else
    Tmp_query :='ALTER ROLE '|| Role_Name|| ' IDENTIFIED BY '|| new_Pwd;
    execute immediate(Tmp_query);
    end if;
end;

