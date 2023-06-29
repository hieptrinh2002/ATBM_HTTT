
--sử dụng thuật toán mã hóa DES_CBC_PKCS5 và một khóa mã hóa cố định
-- sử dụng các hàm mã hóa và giải mã có sẵn trong Oracle như DBMS_CRYPTO.ENCRYPT và DBMS_CRYPTO.DECRYPT
CREATE OR REPLACE FUNCTION ENCRYPT_NV(
    p_input IN NVARCHAR2
) RETURN RAW DETERMINISTIC IS
    l_key RAW(128) := UTL_RAW.CAST_TO_RAW('nnt');
BEGIN
    RETURN DBMS_CRYPTO.ENCRYPT(
        src => UTL_RAW.CAST_TO_RAW(p_input),
        typ => DBMS_CRYPTO.DES_CBC_PKCS5,
        key => l_key
    );
END;
/
/

CREATE OR REPLACE FUNCTION DECRYPT_NV(
    p_input IN RAW
) RETURN NVARCHAR2 DETERMINISTIC IS
    l_key RAW(128) := UTL_RAW.CAST_TO_RAW('nnt');
BEGIN
    RETURN UTL_RAW.CAST_TO_NVARCHAR2(
        DBMS_CRYPTO.DECRYPT(
            src => p_input,
            typ => DBMS_CRYPTO.DES_CBC_PKCS5,
            key => l_key
        )
    );
END;
/


UPDATE NHANVIEN
SET LUONG = ENCRYPT_NV(LUONG);

/
UPDATE NHANVIEN
SET PHUCAP = DECRYPT_NV(PHUCAP);

/
