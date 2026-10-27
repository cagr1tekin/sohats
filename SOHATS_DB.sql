USE master;
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SOHATS')
BEGIN
    CREATE DATABASE SOHATS;
END
GO

USE SOHATS;
GO

-- 1. Poliklinik Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Poliklinik')
BEGIN
    CREATE TABLE Poliklinik (
        poliklinikAd NVARCHAR(50) NOT NULL,
        durum NVARCHAR(10) NOT NULL CHECK (durum IN ('Geçerli', 'Geçersiz')), -- Veya BIT kullanılabilir (1: Geçerli, 0: Geçersiz)
        aciklama NVARCHAR(255),
        CONSTRAINT PK_Poliklinik PRIMARY KEY (poliklinikAd)
    );
END
GO

-- 2. Kullanıcılar Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar')
BEGIN
    CREATE TABLE Kullanicilar (
        kullaniciKod INT IDENTITY(1,1) NOT NULL,
        kullaniciAd NVARCHAR(50) NOT NULL,
        sifre NVARCHAR(50) NOT NULL,
        yetki NVARCHAR(10) NOT NULL CHECK (yetki IN ('admin', 'personel')),
        CONSTRAINT PK_Kullanicilar PRIMARY KEY (kullaniciKod)
    );
END
GO

-- 3. Hastalar Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hastalar')
BEGIN
    CREATE TABLE Hastalar (
        dosyaNo INT IDENTITY(1,1) NOT NULL,
        ad NVARCHAR(50) NOT NULL,
        soyad NVARCHAR(50) NOT NULL,
        tcNo CHAR(11) NOT NULL UNIQUE,
        dogumYeri NVARCHAR(50),
        dogumTarihi DATE,
        medeniHal NVARCHAR(10),
        adres NVARCHAR(255),
        tel NVARCHAR(15),
        CONSTRAINT PK_Hastalar PRIMARY KEY (dosyaNo)
    );
END
GO

-- 4. Sevkler Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Sevkler')
BEGIN
    CREATE TABLE Sevkler (
        sevkTarihi DATETIME NOT NULL DEFAULT GETDATE(),
        dosyaNo INT NOT NULL,
        poliklinikAd NVARCHAR(50) NOT NULL,
        saat CHAR(5), -- Örn: '14:30'
        yapilanIslem NVARCHAR(MAX),
        drKod INT,
        miktar DECIMAL(10, 2),
        
        CONSTRAINT PK_Sevkler PRIMARY KEY (sevkTarihi, dosyaNo),
        
        CONSTRAINT FK_Sevkler_Hastalar FOREIGN KEY (dosyaNo) 
            REFERENCES Hastalar(dosyaNo) 
            ON DELETE CASCADE,
            
        CONSTRAINT FK_Sevkler_Poliklinik FOREIGN KEY (poliklinikAd) 
            REFERENCES Poliklinik(poliklinikAd)
            ON UPDATE CASCADE,
            
        -- drKod için Kullanicilar tablosuna FK eklenebilir (Opsiyonel, doktorlar kullanıcı ise)
        CONSTRAINT FK_Sevkler_Doktor FOREIGN KEY (drKod)
            REFERENCES Kullanicilar(kullaniciKod)
    );
END
GO

-- Stored Procedure: dbo.sevk_ekle
IF OBJECT_ID('dbo.sevk_ekle', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sevk_ekle;
GO

CREATE PROCEDURE dbo.sevk_ekle
    @dosyaNo INT,
    @poliklinikAd NVARCHAR(50),
    @saat CHAR(5),
    @yapilanIslem NVARCHAR(MAX),
    @drKod INT,
    @miktar DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Sevk tarihi o anki tarih olsun
    DECLARE @sevkTarihi DATETIME = GETDATE();

    INSERT INTO Sevkler (sevkTarihi, dosyaNo, poliklinikAd, saat, yapilanIslem, drKod, miktar)
    VALUES (@sevkTarihi, @dosyaNo, @poliklinikAd, @saat, @yapilanIslem, @drKod, @miktar);
    
    SELECT 'Sevk başarıyla eklendi.' AS Sonuc;
END
GO

-- Stored Procedure: dbo.hasta_bul
IF OBJECT_ID('dbo.hasta_bul', 'P') IS NOT NULL
    DROP PROCEDURE dbo.hasta_bul;
GO

CREATE PROCEDURE dbo.hasta_bul
    @aramaKriteri NVARCHAR(50) -- Dosya No veya TC No veya Ad olabilir
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Hastalar
    WHERE 
        CAST(dosyaNo AS NVARCHAR) = @aramaKriteri
        OR tcNo = @aramaKriteri
        OR ad LIKE '%' + @aramaKriteri + '%'
        OR soyad LIKE '%' + @aramaKriteri + '%';
END
GO
