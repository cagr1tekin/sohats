USE master;
GO

-- Eski veritabanını silip yeniden oluştur
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'SOHATS')
BEGIN
    ALTER DATABASE SOHATS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SOHATS;
END
GO

CREATE DATABASE SOHATS;
GO

USE SOHATS;
GO

-- 1. Poliklinik Tablosu
CREATE TABLE [dbo].[poliklinik](
	[poliklinikadi] [nvarchar](50) NOT NULL,
	[durum] [nvarchar](5) NULL,
	[aciklama] [nvarchar](255) NULL,
 CONSTRAINT [PK_poliklinik] PRIMARY KEY CLUSTERED ([poliklinikadi] ASC)
)
GO

-- 2. Kullanıcı Tablosu
CREATE TABLE [dbo].[kullanici](
	[kodu] [nvarchar](20) NOT NULL,
	[ad] [nvarchar](20) NULL,
	[soyad] [nvarchar](20) NULL,
	[sifre] [nvarchar](20) NULL,
	[yetki] [nvarchar](5) NULL,
	[ceptel] [nvarchar](11) NULL,
	[adres] [nvarchar](255) NULL,
	[unvan] [nvarchar](15) NULL,
	[isebaslama] [datetime] NULL,
	[maas] [nvarchar](20) NULL,
	[dogumyeri] [nvarchar](50) NULL,
	[anneadi] [nvarchar](20) NULL,
	[babadi] [nvarchar](20) NULL,
	[cinsiyet] [nvarchar](5) NULL,
	[kangubu] [nvarchar](10) NULL,
	[medenihal] [nvarchar](10) NULL,
	[dogumtarihi] [datetime] NULL,
	[tcKimlikno] [nvarchar](11) NULL,
	[username] [nvarchar](50) NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED ([kodu] ASC)
)
GO

-- 3. Hasta Tablosu
CREATE TABLE [dbo].[hasta](
	[tcKimlikNo] [nvarchar](10) NOT NULL,
	[dosyano] [nvarchar](10) NULL,
	[ad] [nvarchar](15) NULL,
	[soyad] [nvarchar](15) NULL,
	[dogumyeri] [nvarchar](15) NULL,
	[dogumtarihi] [datetime] NULL,
	[babadi] [nvarchar](15) NULL,
	[anneadi] [nvarchar](15) NULL,
	[cinsiyet] [nvarchar](5) NULL,
	[kangubu] [nvarchar](5) NULL,
	[medenihal] [nvarchar](5) NULL,
	[adres] [nvarchar](255) NULL,
	[tel] [nvarchar](11) NULL,
	[kurumsicilno] [nvarchar](10) NULL,
	[kurumadi] [nvarchar](50) NULL,
	[yakintel] [nvarchar](11) NULL,
	[yakinkurumsicilno] [nvarchar](10) NULL,
	[yakinkurumadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_hasta] PRIMARY KEY CLUSTERED ([tcKimlikNo] ASC)
)
GO

-- 4. İşlem Tablosu
CREATE TABLE [dbo].[islem](
	[islemAdi] [nvarchar](50) NULL,
	[birimFiyat] [nvarchar](50) NULL
)
GO

-- 5. Sevk Tablosu
CREATE TABLE [dbo].[sevk](
	[sevktarihi] [nvarchar](10) NULL,
	[dosyano] [nvarchar](50) NULL,
	[poliklinik] [nvarchar](50) NULL,
	[saat] [nvarchar](10) NULL,
	[yapilanislem] [nvarchar](50) NULL,
	[drkod] [char](10) NULL,
	[miktar] [char](3) NULL,
	[birimfiyat] [nvarchar](20) NULL,
	[sira] [char](3) NULL,
	[toplamtutar] [nvarchar](50) NULL,
	[taburcu] [nvarchar](50) NULL
)
GO

-- 6. Çıkış Tablosu
CREATE TABLE [dbo].[cikis](
	[dosyano] [nvarchar](10) NULL,
	[sevktarihi] [nvarchar](10) NULL,
	[cikissaati] [datetime] NULL,
	[odeme] [nvarchar](20) NULL,
	[toplamtutar] [nvarchar](20) NULL
)
GO

-- Örnek veriler ekle
INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, username) VALUES ('1', 'Admin', 'Kullanıcı', '1234', 'admin', 'admin');
GO

INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Muayene', '100');
INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Kan Tahlili', '50');
INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Röntgen', '75');
INSERT INTO islem (islemAdi, birimFiyat) VALUES ('EKG', '80');
GO

-- ==================== SAKLI YORDAMLAR (STORED PROCEDURES) ====================

-- POLIKLINIK STORED PROCEDURES
IF OBJECT_ID('dbo.insert_polikinlik', 'P') IS NOT NULL DROP PROCEDURE dbo.insert_polikinlik;
GO
CREATE PROCEDURE dbo.insert_polikinlik
    @poliklinikadi NVARCHAR(50),
    @durum NVARCHAR(5),
    @aciklama NVARCHAR(255)
AS
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama)
    VALUES (@poliklinikadi, @durum, @aciklama);
END
GO

IF OBJECT_ID('dbo.update_polikinlik', 'P') IS NOT NULL DROP PROCEDURE dbo.update_polikinlik;
GO
CREATE PROCEDURE dbo.update_polikinlik
    @poliklinikadi NVARCHAR(50),
    @durum NVARCHAR(5),
    @aciklama NVARCHAR(255)
AS
BEGIN
    UPDATE poliklinik 
    SET durum = @durum, aciklama = @aciklama
    WHERE poliklinikadi = @poliklinikadi;
END
GO

IF OBJECT_ID('dbo.delete_polikinlik', 'P') IS NOT NULL DROP PROCEDURE dbo.delete_polikinlik;
GO
CREATE PROCEDURE dbo.delete_polikinlik
    @poliklinikadi NVARCHAR(50)
AS
BEGIN
    DELETE FROM poliklinik WHERE poliklinikadi = @poliklinikadi;
END
GO

-- KULLANICI STORED PROCEDURES
IF OBJECT_ID('dbo.insert_kullanici', 'P') IS NOT NULL DROP PROCEDURE dbo.insert_kullanici;
GO
CREATE PROCEDURE dbo.insert_kullanici
    @kodu NVARCHAR(20),
    @ad NVARCHAR(20),
    @soyad NVARCHAR(20),
    @sifre NVARCHAR(20),
    @yetki NVARCHAR(5),
    @ceptel NVARCHAR(11),
    @adres NVARCHAR(255),
    @unvan NVARCHAR(15),
    @isebaslama DATETIME,
    @maas NVARCHAR(20),
    @dogumyeri NVARCHAR(50),
    @anneadi NVARCHAR(20),
    @babadi NVARCHAR(20),
    @cinsiyet NVARCHAR(5),
    @kangubu NVARCHAR(10),
    @medenihal NVARCHAR(10),
    @dogumtarihi DATETIME,
    @tcKimlikno NVARCHAR(11),
    @username NVARCHAR(50)
AS
BEGIN
    INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, ceptel, adres, unvan, isebaslama, maas, 
                          dogumyeri, anneadi, babadi, cinsiyet, kangubu, medenihal, dogumtarihi, tcKimlikno, username)
    VALUES (@kodu, @ad, @soyad, @sifre, @yetki, @ceptel, @adres, @unvan, @isebaslama, @maas,
            @dogumyeri, @anneadi, @babadi, @cinsiyet, @kangubu, @medenihal, @dogumtarihi, @tcKimlikno, @username);
END
GO

IF OBJECT_ID('dbo.update_kullanici', 'P') IS NOT NULL DROP PROCEDURE dbo.update_kullanici;
GO
CREATE PROCEDURE dbo.update_kullanici
    @kodu NVARCHAR(20),
    @ad NVARCHAR(20),
    @soyad NVARCHAR(20),
    @sifre NVARCHAR(20),
    @yetki NVARCHAR(5),
    @ceptel NVARCHAR(11),
    @adres NVARCHAR(255),
    @unvan NVARCHAR(15),
    @isebaslama DATETIME,
    @maas NVARCHAR(20),
    @dogumyeri NVARCHAR(50),
    @anneadi NVARCHAR(20),
    @babadi NVARCHAR(20),
    @cinsiyet NVARCHAR(5),
    @kangubu NVARCHAR(10),
    @medenihal NVARCHAR(10),
    @dogumtarihi DATETIME,
    @tcKimlikno NVARCHAR(11),
    @username NVARCHAR(50)
AS
BEGIN
    UPDATE kullanici 
    SET ad = @ad, soyad = @soyad, sifre = @sifre, yetki = @yetki, ceptel = @ceptel,
        adres = @adres, unvan = @unvan, isebaslama = @isebaslama, maas = @maas,
        dogumyeri = @dogumyeri, anneadi = @anneadi, babadi = @babadi, cinsiyet = @cinsiyet,
        kangubu = @kangubu, medenihal = @medenihal, dogumtarihi = @dogumtarihi, 
        tcKimlikno = @tcKimlikno, username = @username
    WHERE kodu = @kodu;
END
GO

IF OBJECT_ID('dbo.delete_kullanici', 'P') IS NOT NULL DROP PROCEDURE dbo.delete_kullanici;
GO
CREATE PROCEDURE dbo.delete_kullanici
    @kodu NVARCHAR(20)
AS
BEGIN
    DELETE FROM kullanici WHERE kodu = @kodu;
END
GO

-- HASTA STORED PROCEDURES
IF OBJECT_ID('dbo.insert_hasta', 'P') IS NOT NULL DROP PROCEDURE dbo.insert_hasta;
GO
CREATE PROCEDURE dbo.insert_hasta
    @tcKimlikNo NVARCHAR(10),
    @dosyano NVARCHAR(10),
    @ad NVARCHAR(15),
    @soyad NVARCHAR(15),
    @dogumyeri NVARCHAR(15),
    @dogumtarihi DATETIME,
    @babadi NVARCHAR(15),
    @anneadi NVARCHAR(15),
    @cinsiyet NVARCHAR(5),
    @kangubu NVARCHAR(5),
    @medenihal NVARCHAR(5),
    @adres NVARCHAR(255),
    @tel NVARCHAR(11),
    @kurumsicilno NVARCHAR(10),
    @kurumadi NVARCHAR(50),
    @yakintel NVARCHAR(11),
    @yakinkurumsicilno NVARCHAR(10),
    @yakinkurumadi NVARCHAR(50)
AS
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi,
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi,
                       yakintel, yakinkurumsicilno, yakinkurumadi)
    VALUES (@tcKimlikNo, @dosyano, @ad, @soyad, @dogumyeri, @dogumtarihi, @babadi, @anneadi,
            @cinsiyet, @kangubu, @medenihal, @adres, @tel, @kurumsicilno, @kurumadi,
            @yakintel, @yakinkurumsicilno, @yakinkurumadi);
END
GO

IF OBJECT_ID('dbo.update_hasta', 'P') IS NOT NULL DROP PROCEDURE dbo.update_hasta;
GO
CREATE PROCEDURE dbo.update_hasta
    @tcKimlikNo NVARCHAR(10),
    @dosyano NVARCHAR(10),
    @ad NVARCHAR(15),
    @soyad NVARCHAR(15),
    @dogumyeri NVARCHAR(15),
    @dogumtarihi DATETIME,
    @babadi NVARCHAR(15),
    @anneadi NVARCHAR(15),
    @cinsiyet NVARCHAR(5),
    @kangubu NVARCHAR(5),
    @medenihal NVARCHAR(5),
    @adres NVARCHAR(255),
    @tel NVARCHAR(11),
    @kurumsicilno NVARCHAR(10),
    @kurumadi NVARCHAR(50),
    @yakintel NVARCHAR(11),
    @yakinkurumsicilno NVARCHAR(10),
    @yakinkurumadi NVARCHAR(50)
AS
BEGIN
    UPDATE hasta 
    SET dosyano = @dosyano, ad = @ad, soyad = @soyad, dogumyeri = @dogumyeri,
        dogumtarihi = @dogumtarihi, babadi = @babadi, anneadi = @anneadi,
        cinsiyet = @cinsiyet, kangubu = @kangubu, medenihal = @medenihal,
        adres = @adres, tel = @tel, kurumsicilno = @kurumsicilno, kurumadi = @kurumadi,
        yakintel = @yakintel, yakinkurumsicilno = @yakinkurumsicilno, yakinkurumadi = @yakinkurumadi
    WHERE tcKimlikNo = @tcKimlikNo;
END
GO

IF OBJECT_ID('dbo.delete_hasta', 'P') IS NOT NULL DROP PROCEDURE dbo.delete_hasta;
GO
CREATE PROCEDURE dbo.delete_hasta
    @tcKimlikNo NVARCHAR(10)
AS
BEGIN
    DELETE FROM hasta WHERE tcKimlikNo = @tcKimlikNo;
END
GO

IF OBJECT_ID('dbo.hastaAdd_ile_bul', 'P') IS NOT NULL DROP PROCEDURE dbo.hastaAdd_ile_bul;
GO
CREATE PROCEDURE dbo.hastaAdd_ile_bul
    @dosyano NVARCHAR(10)
AS
BEGIN
    SELECT * FROM hasta WHERE dosyano = @dosyano;
END
GO

IF OBJECT_ID('dbo.guvceana_ile_bul', 'P') IS NOT NULL DROP PROCEDURE dbo.guvceana_ile_bul;
GO
CREATE PROCEDURE dbo.guvceana_ile_bul
    @tcKimlikNo NVARCHAR(10)
AS
BEGIN
    SELECT * FROM hasta WHERE tcKimlikNo = @tcKimlikNo;
END
GO

-- SEVK STORED PROCEDURES
IF OBJECT_ID('dbo.insert_sevk', 'P') IS NOT NULL DROP PROCEDURE dbo.insert_sevk;
GO
CREATE PROCEDURE dbo.insert_sevk
    @sevktarihi NVARCHAR(10),
    @dosyano NVARCHAR(50),
    @poliklinik NVARCHAR(50),
    @saat NVARCHAR(10),
    @yapilanislem NVARCHAR(50),
    @drkod CHAR(10),
    @miktar CHAR(3),
    @birimfiyat NVARCHAR(20),
    @sira CHAR(3),
    @toplamtutar NVARCHAR(50),
    @taburcu NVARCHAR(50)
AS
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@sevktarihi, @dosyano, @poliklinik, @saat, @yapilanislem, @drkod, @miktar, @birimfiyat, @sira, @toplamtutar, @taburcu);
END
GO

IF OBJECT_ID('dbo.update_sevk', 'P') IS NOT NULL DROP PROCEDURE dbo.update_sevk;
GO
CREATE PROCEDURE dbo.update_sevk
    @sevktarihi NVARCHAR(10),
    @dosyano NVARCHAR(50),
    @poliklinik NVARCHAR(50),
    @saat NVARCHAR(10),
    @yapilanislem NVARCHAR(50),
    @drkod CHAR(10),
    @miktar CHAR(3),
    @birimfiyat NVARCHAR(20),
    @sira CHAR(3),
    @toplamtutar NVARCHAR(50),
    @taburcu NVARCHAR(50)
AS
BEGIN
    UPDATE sevk 
    SET poliklinik = @poliklinik, saat = @saat, yapilanislem = @yapilanislem,
        drkod = @drkod, miktar = @miktar, birimfiyat = @birimfiyat,
        sira = @sira, toplamtutar = @toplamtutar, taburcu = @taburcu
    WHERE sevktarihi = @sevktarihi AND dosyano = @dosyano;
END
GO

IF OBJECT_ID('dbo.delete_sevk', 'P') IS NOT NULL DROP PROCEDURE dbo.delete_sevk;
GO
CREATE PROCEDURE dbo.delete_sevk
    @sevktarihi NVARCHAR(10),
    @dosyano NVARCHAR(50)
AS
BEGIN
    DELETE FROM sevk WHERE sevktarihi = @sevktarihi AND dosyano = @dosyano;
END
GO

-- ÇIKIŞ STORED PROCEDURES
IF OBJECT_ID('dbo.insert_Cikis', 'P') IS NOT NULL DROP PROCEDURE dbo.insert_Cikis;
GO
CREATE PROCEDURE dbo.insert_Cikis
    @dosyano NVARCHAR(10),
    @sevktarihi NVARCHAR(10),
    @cikissaati DATETIME,
    @odeme NVARCHAR(20),
    @toplamtutar NVARCHAR(20)
AS
BEGIN
    INSERT INTO cikis (dosyano, sevktarihi, cikissaati, odeme, toplamtutar)
    VALUES (@dosyano, @sevktarihi, @cikissaati, @odeme, @toplamtutar);
END
GO
