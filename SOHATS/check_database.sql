-- Veritabanı tablo adlarını kontrol et
USE SOHATS;
GO

-- Tüm tabloları listele
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
GO

-- Kullanıcı tablosunu kontrol et
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'kullanici')
    SELECT 'kullanici tablosu VAR' AS Durum;
ELSE
    SELECT 'kullanici tablosu YOK' AS Durum;

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar')
    SELECT 'Kullanicilar tablosu VAR' AS Durum;
ELSE
    SELECT 'Kullanicilar tablosu YOK' AS Durum;
GO

-- kullanici tablosunun kolonlarını göster
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'kullanici')
BEGIN
    SELECT COLUMN_NAME, DATA_TYPE 
    FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'kullanici'
    ORDER BY ORDINAL_POSITION;
END
GO

