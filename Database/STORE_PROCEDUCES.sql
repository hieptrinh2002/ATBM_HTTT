
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

-- TẠO USERS
CREATE OR REPLACE PROCEDURE CREATE_ALL_USERS
AS
    CURSOR CURS AS (SELECT MANV , VAITRO FROM NHANVIEN WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    _USERNAME NHANVIEN.MANV%TYPE;
    _ROLE NHANVIEN.VAITRO%TYPE;
BEGIN 
    CURS.OPEN();
      LOOP 
        FETCH CURS INTO _USERNAME,_ROLE;
        EXIT WHEN CURS%NOTFOUND;
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
        execute immediate('CREATE USER '|| _USERNAME||' IDENTIFIED by '||_USERNAME);
        execute immediate('GRANT CREATE SESSION TO '||_USERNAME);
        execute immediate('GRANT CONNECT TO '||_USERNAME);
        execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');

        IF (_ROLE = N'Nhân viên') THEN  
          execute immediate('GRANT NHANVIEN TO '||_USERNAME);

        ELSIF (_ROLE = N'QL trực Tiếp') THEN 
          execute immediate('GRANT QLTRUCTIEP TO '||_USERNAME);

        ELSIF (_ROLE = N'Trưởng thòng') THEN 
          execute immediate('GRANT TRUONGPHONG TO '||_USERNAME);
          
        ELSIF (_ROLE = N'Tài chính') THEN 
          execute immediate('GRANT TAICHINH TO '||_USERNAME);

        ELSIF (_ROLE = N'Nhân sự') THEN 
          execute immediate('GRANT NHANSU TO '||_USERNAME);
s
        ELSIF (_ROLE = N'Trưởng đề án') THEN 
          execute immediate('GRANT TRUONGDA TO '||_USERNAME);
        END IF;
      END LOOP;
    CURS.CLOSE(); 

    EXCEPTION
       WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001,'ERORR WHEN CREATE LIST USER !!!');

END;

