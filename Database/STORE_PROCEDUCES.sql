
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

--Thêm phòng ban
CREATE OR REPLACE PROCEDURE SP_NHANSU_THEM_PHONGBAN( p_mapb VARCHAR2,p_tenpb VARCHAR2, p_trphg VARCHAR2)
IS
     p_count1 NUMBER;
      p_count2 number;
BEGIN
    SELECT COUNT(*) INTO p_count1 FROM PHONGBAN  WHERE TRPHG = p_trphg;    
    SELECT COUNT(*) INTO p_count2 FROM PHONGBAN  WHERE MAPB = p_mapb;
    IF(P_count1 < 1 AND p_trphg IS NOT NULL) then
         raise_application_error(-20000, 'Mã trưởng phòng không tồn tại');
    ELSIF (P_count2 > 0) THEN 
         raise_application_error(-20000, 'Mã phòng đã tồn tại');
    ELSE
    INSERT INTO PHONGBAN (MAPB, TENPB, TRPHG) VALUES (p_mapb, p_tenpb, p_trphg);
    END IF;
END;
/
GRANT EXECUTE ON SP_NHANSU_THEM_PHONGBAN TO NHANSU;

/
create or replace NONEDITIONABLE PROCEDURE UPDATE_PROFILE(Ten_in NVARCHAR2,NGAYSINH_in DATE, DIACHI_in NVARCHAR2, SODT_in VARCHAR, MANV_in VARCHAR)
AS 
BEGIN
update NHANVIEN NV
set NV.TENNV = Ten_in,
    NV.NGAYSINH = NGAYSINH_in,
    NV.DIACHI = DIACHI_in,
    NV.SODT = SODT_in
where NV.MANV = MANV_in;

END;
/
-- nhân sự cập nhật phòng ban
CREATE OR REPLACE PROCEDURE USP_NHANSU_CAPNHAT_PHONGBAN(
    p_mapb IN VARCHAR2,
    p_tenpb IN VARCHAR2,
    p_trphg IN VARCHAR2
)
AS    
      p_count1 NUMBER;
      p_count2 NUMBER;
BEGIN
    SELECT COUNT(*) INTO p_count1 FROM PHONGBAN  WHERE TRPHG = p_trphg;  
    
    IF(P_count1 < 1 AND p_trphg IS NOT NULL) then
         raise_application_error(-20000, 'Mã trưởng phòng mới không tồn tại');
    END IF;
    
    SELECT COUNT(*) INTO p_count2 FROM PHONGBAN  WHERE MAPB = p_mapb; -- 
    
    IF (P_count2 < 1) THEN  -- KIỂM TRA TỒN TẠI CỦA PHÒNG BAN
         raise_application_error(-20000, 'Mã phòng cần cập nhật không tồn tại');
    ELSE 
       UPDATE PHONGBAN
        SET TENPB = p_tenpb,
            TRPHG = p_trphg
        WHERE MAPB = p_mapb;
    END IF;
END;
/
GRANT EXECUTE ON USP_NHANSU_CAPNHAT_PHONGBAN TO NHANSU;
/
EXEC USP_NHANSU_CAPNHAT_PHONGBAN('PB00013',N'PHONG TEST_Y','NV041');
/
-- nhân sự thêm nhân viên 

CREATE OR REPLACE PROCEDURE SP_NHANSU_THEMNHANVIEN(
    p_MANV IN NVARCHAR2,
    p_TENNV IN NVARCHAR2,
    p_PHAI IN NVARCHAR2,
    p_NGAYSINH IN DATE,
    p_DIACHI IN NVARCHAR2,
    p_SODT IN NVARCHAR2,
    p_VAITRO IN NVARCHAR2,
    p_MANQL IN NVARCHAR2,
    p_PHG IN NVARCHAR2
) 
AS    
      p_count1 NUMBER;
      p_count2 NUMBER;
      p_count3 NUMBER;
BEGIN
    SELECT COUNT(*) INTO p_count1 FROM NHANVIEN  WHERE MANV = p_MANV;  
    IF(P_count1 > 0 ) then
         raise_application_error(-20000, 'Mã nhân viên đã tồn tại');
    END IF;
    
    SELECT COUNT(*) INTO p_count2 FROM PHONGBAN  WHERE MAPB = p_PHG;  
        
    IF (p_PHG is not null and P_count2 < 1) THEN  -- KIỂM TRA TỒN TẠI CỦA PHÒNG BAN
         raise_application_error(-20000, 'Mã phòng ban không tồn tại');
    END IF;     
    
    SELECT COUNT(*) INTO p_count3 FROM NHANVIEN  WHERE MANQL = p_MANQL;  
    IF (p_MANQL is not null and p_count3 < 1) THEN  -- KIỂM TRA TỒN TẠI CỦA NVQL
         raise_application_error(-20000, 'Mã quản lý không tồn tại');
    END IF;
    
    INSERT INTO  NHANVIEN(MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG)
    VALUES (p_MANV, p_TENNV, p_PHAI, p_NGAYSINH, p_DIACHI, p_SODT, p_VAITRO, p_MANQL, p_PHG);
    
END;
/
    
GRANT EXECUTE ON SP_NHANSU_THEMNHANVIEN TO NHANSU;
/
EXEC SP_NHANSU_THEMNHANVIEN('NV076',N'Võ Văn Nam','Nam',to_date('10/10/2002','dd/mm/yyyy'),N'Quảng Nam','0954738292',N'Nhân viên','NV007','PB0004');
-- nhân sự cập nhật nhân viên

CREATE OR REPLACE PROCEDURE SP_NHANSU_CAPNHAT_NHANVIEN(
    p_MANV IN NVARCHAR2,
    p_TENNV IN NVARCHAR2,
    p_PHAI IN NVARCHAR2,
    p_NGAYSINH IN DATE,
    p_DIACHI IN NVARCHAR2,
    p_SODT IN NVARCHAR2,
    p_VAITRO IN NVARCHAR2,
    p_MANQL IN NVARCHAR2,
    p_PHG IN NVARCHAR2
) 
AS    
      p_count1 NUMBER;
      p_count2 NUMBER;
      p_count3 NUMBER;
BEGIN
    SELECT COUNT(*) INTO p_count1 FROM NHANVIEN  WHERE MANV = p_MANV;  
    IF(P_count1 < 1) then
         raise_application_error(-20000, 'Mã nhân cập nhật không tồn tại');
    END IF;
    
    SELECT COUNT(*) INTO p_count2 FROM PHONGBAN  WHERE MAPB = p_PHG;  
        
    IF (p_PHG is not null and P_count2 < 1) THEN  -- KIỂM TRA TỒN TẠI CỦA PHÒNG BAN
         raise_application_error(-20000, 'Mã phòng ban không tồn tại');
    END IF;     
    
    SELECT COUNT(*) INTO p_count3 FROM NHANVIEN  WHERE MANV = p_MANQL;  
    IF (p_MANQL is not null and P_count3 < 1) THEN  -- KIỂM TRA TỒN TẠI CỦA PHÒNG BAN
         raise_application_error(-20000, 'Mã quản lý không tồn tại');
    END IF;
    UPDATE NHANVIEN NV
    SET TENNV = p_TENNV,PHAI = p_PHAI, NGAYSINH = p_NGAYSINH,
    DIACHI = p_DIACHI,SODT = p_SODT, VAITRO =  p_VAITRO, MANQL =  p_MANQL,PHG = p_PHG 
    WHERE MANV = p_MANV;
    
END;
/
GRANT EXECUTE ON SP_NHANSU_CAPNHAT_NHANVIEN TO NHANSU;

/

-- Trưởng phòng Thêm phân công    
CREATE OR REPLACE PROCEDURE SP_TRUONGPHONG_THEM_PHANCONG(
    p_manv IN VARCHAR2,
    p_mada IN VARCHAR2,
    p_ngaybatdau IN DATE
)
AS
    v_count1 NUMBER;
    v_count2 NUMBER;
    v_count3 NUMBER;
BEGIN
    SELECT COUNT(*) INTO v_count1
    FROM VIEW_TRUONGPHONG_THONGTIN_PHANCONG
    WHERE MANV = p_manv AND MADA = p_mada;
    IF v_count1 > 0 THEN
        raise_application_error(-20000, 'Phân công đã tồn tại');
    END IF;
    
    SELECT COUNT(*) INTO v_count2
    FROM DEAN
    WHERE MADA = p_mada;
    IF v_count2 < 1 THEN
        raise_application_error(-20000, 'Mã đề án không hợp lệ !!');
    END IF;
    
    SELECT COUNT(*) INTO v_count3
    FROM QLTGDA.VIEW_TRUONGPHONG_THONGTIN_PHANCONG
    WHERE MANV = p_manv;
    
    IF v_count3 < 1 THEN
        raise_application_error(-20000, 'Nhân viên không tồn tại hoặc không thuộc quyền bạn quản lý !!');
    END IF;
    
    INSERT INTO PHANCONG (MANV, MADA, THOIGIAN) VALUES (p_manv, p_mada,p_ngaybatdau);

END;
/
GRANT EXECUTE ON SP_TRUONGPHONG_THEM_PHANCONG TO TRUONGPHONG;
/
EXEC QLTGDA.SP_TRUONGPHONG_THEM_PHANCONG('NV009', 'DA0006', to_date('25/06/2023', 'DD/MM/YYYY'));

/
-- Trưởng phòng cập nhật phân công
CREATE OR REPLACE PROCEDURE SP_TRUONGPHONG_CAPNHAT_PHANCONG(
    p_manv IN VARCHAR2,
    p_mada IN VARCHAR2,
    p_thoigian IN DATE
)
AS
    v_count1 INTEGER;
BEGIN
    SELECT COUNT(*) INTO v_count1
    FROM VIEW_TRUONGPHONG_THONGTIN_PHANCONG
    WHERE MANV = p_manv AND MADA = p_mada;
    IF v_count1 != 1 THEN
        raise_application_error(-20000, 'Không tìm thấy phân công !');
    END IF;

    UPDATE PHANCONG
    SET THOIGIAN = p_thoigian
    WHERE MANV = p_manv AND MADA = p_mada;
END;
/
GRANT EXECUTE ON SP_TRUONGPHONG_CAPNHAT_PHANCONG TO TRUONGPHONG;
/
-- Trưởng phòng xóa phân công
CREATE OR REPLACE PROCEDURE SP_TRUONGPHONG_XOA_PHANCONG(
    p_manv IN VARCHAR2,
    p_mada IN VARCHAR2
)
AS
    v_count1 INTEGER;
BEGIN
    SELECT COUNT(*) INTO v_count1
    FROM VIEW_TRUONGPHONG_THONGTIN_PHANCONG
    WHERE MANV = p_manv AND MADA = p_mada;
    IF v_count1 != 1 THEN
        raise_application_error(-20000, 'Không tìm thấy phân công !');
    END IF;

    DELETE FROM PHANCONG
    WHERE MANV = p_manv AND MADA = p_mada;
END;
/
GRANT EXECUTE ON SP_TRUONGPHONG_XOA_PHANCONG TO TRUONGPHONG;
/

--Trưởng đề án thêm đề án 

CREATE OR REPLACE PROCEDURE SP_TRUONGDEAN_THEM_DEAN(
    p_mada IN VARCHAR2,
    p_tenda IN NVARCHAR2,
    p_ngaybatdau IN DATE,
    p_phong IN VARCHAR2
)
AS
    v_count1 INTEGER;
BEGIN
    SELECT COUNT(*) INTO v_count1
    FROM DEAN
    WHERE MADA = p_mada;
    IF v_count1 = 1 THEN
        raise_application_error(-20000, 'đề án đã tồn tại !');
    END IF;

    INSERT INTO DEAN (MADA, TENDA, NGAYBD, PHONG)
    VALUES (p_mada, p_tenda, p_ngaybatdau, p_phong);    
END;
/
GRANT EXECUTE ON SP_TRUONGDEAN_THEM_DEAN TO TRUONGDA;
/

-- TÀI CHÍNH CẬP NHẬT LƯƠNG 
CREATE OR REPLACE PROCEDURE SP_TAICHINH_UPDATE_LUONG_PHUCAP_NHANVIEN (
    p_manv IN NHANVIEN.MANV%TYPE,
    p_luong IN NHANVIEN.LUONG%TYPE,
    p_phucap IN NHANVIEN.PHUCAP%TYPE
)
AS
BEGIN
    UPDATE NHANVIEN
    SET LUONG = p_luong, PHUCAP = p_phucap
    WHERE MANV = p_manv;

    IF SQL%ROWCOUNT = 0 THEN
        raise_application_error(-20000, 'nhân viên không tồn tại !');
        ROLLBACK;
    END IF;
END;
/
GRANT EXECUTE ON SP_TAICHINH_UPDATE_LUONG_PHUCAP_NHANVIEN TO TAICHINH;
/