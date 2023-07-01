
--sử dụng thuật toán mã hóa DES_CBC_PKCS5 và một khóa mã hóa cố định
-- sử dụng các hàm mã hóa và giải mã có sẵn trong Oracle như DBMS_CRYPTO.ENCRYPT và DBMS_CRYPTO.DECRYPT

-- Hàm mã hóa
CREATE OR REPLACE FUNCTION EncryptNV(p_luong IN VARCHAR2, p_key IN VARCHAR2)
  RETURN RAW
IS
  l_encrypted RAW(2000);
BEGIN
  l_encrypted := DBMS_CRYPTO.ENCRYPT(
    src => UTL_I18N.STRING_TO_RAW(p_luong, 'AL32UTF8'),
    typ => DBMS_CRYPTO.DES_CBC_PKCS5,
    key => UTL_I18N.STRING_TO_RAW(p_key, 'AL32UTF8')
  );

  RETURN l_encrypted;
END;
/

-- Hàm giải mã
CREATE OR REPLACE FUNCTION DecryptNV(p_encrypted IN RAW, p_key IN VARCHAR2)
  RETURN VARCHAR2
IS
  l_decrypted VARCHAR2(100);
BEGIN
  l_decrypted := UTL_I18N.RAW_TO_CHAR(
    DBMS_CRYPTO.DECRYPT(
      src => p_encrypted,
      typ => DBMS_CRYPTO.DES_CBC_PKCS5,
      key => UTL_I18N.STRING_TO_RAW(p_key, 'AL32UTF8')
    ),
    'AL32UTF8'
  );

  RETURN l_decrypted;
END;
/

-- Mã hóa dữ liệu trong cột LUONG
UPDATE NHANVIEN
SET LUONG = RAWTOHEX(EncryptNV(LUONG, 'YourEncryptionKey'));

/
UPDATE NHANVIEN
SET PHUCAP = RAWTOHEX(EncryptNV(PHUCAP, 'YourEncryptionKey'));
/
CREATE OR REPLACE FUNCTION DecryptLuong(p_encrypted_value IN RAW, p_key IN VARCHAR2)
  RETURN VARCHAR2
AS
  l_decrypted_raw RAW(2000);
  l_decrypted_value VARCHAR2(100);
BEGIN
  l_decrypted_raw := DBMS_CRYPTO.DECRYPT(p_encrypted_value, DBMS_CRYPTO.DES_CBC_PKCS5, UTL_I18N.STRING_TO_RAW(p_key));

  l_decrypted_value := UTL_I18N.RAW_TO_CHAR(l_decrypted_raw);

  RETURN l_decrypted_value;
END;
/


