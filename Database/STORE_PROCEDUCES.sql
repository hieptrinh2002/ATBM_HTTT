
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

select * from all_users
/-- TẠO LIST USER
DECLARE
    CURSOR CURS IS (SELECT MANV,VAITRO FROM NHANVIEN WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    USERNAME NHANVIEN.MANV%TYPE;
    ROLE_VT NHANVIEN.VAITRO%TYPE;
    strSQL VARCHAR2(3000);
BEGIN 
    OPEN CURS;
    strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE (strSQL);
      LOOP 
        FETCH CURS INTO USERNAME,ROLE_VT;
        EXIT WHEN CURS%NOTFOUND;
        execute immediate('CREATE USER '||USERNAME||' IDENTIFIED BY '||USERNAME);
        execute immediate('GRANT CREATE SESSION TO '||USERNAME);
        execute immediate('GRANT CONNECT TO '||USERNAME);
        IF (ROLE_VT = N'Nh�n vi�n') THEN  
          execute immediate('GRANT NHANVIEN TO '||USERNAME);

        ELSIF (ROLE_VT = N'QL trực tiếp') THEN 
          execute immediate('GRANT QLTRUCTIEP TO '||USERNAME);

        ELSIF (ROLE_VT = N'Trưởng phòng') THEN 
          execute immediate('GRANT TRUONGPHONG TO '||USERNAME);
          
        ELSIF (ROLE_VT = N'Tài chính') THEN 
          execute immediate('GRANT TAICHINH TO '||USERNAME);

        ELSIF (ROLE_VT = N'Nhân sự') THEN 
          execute immediate('GRANT NHANSU TO '||USERNAME);

        ELSIF (ROLE_VT = N'trưởng đề án') THEN 
          execute immediate('GRANT TRUONGDA TO '||USERNAME);
        END IF;
      END LOOP;
    execute immediate('ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE');
    CLOSE CURS; 
     
END;