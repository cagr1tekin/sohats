USE SOHATS;
GO

-- ==================== ÖRNEK VERİLER ====================

-- 1. POLİKLİNİK ÖRNEKLERİ
IF NOT EXISTS (SELECT * FROM poliklinik WHERE poliklinikadi = 'Genel Pratisyen')
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('Genel Pratisyen', 'Geçerli', 'Genel muayene ve tedavi');
END

IF NOT EXISTS (SELECT * FROM poliklinik WHERE poliklinikadi = 'Kardiyoloji')
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('Kardiyoloji', 'Geçerli', 'Kalp ve dolaşım sistemi hastalıkları');
END

IF NOT EXISTS (SELECT * FROM poliklinik WHERE poliklinikadi = 'Dahiliye')
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('Dahiliye', 'Geçerli', 'İç hastalıkları');
END

IF NOT EXISTS (SELECT * FROM poliklinik WHERE poliklinikadi = 'Ortopedi')
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('Ortopedi', 'Geçerli', 'Kemik ve eklem hastalıkları');
END

IF NOT EXISTS (SELECT * FROM poliklinik WHERE poliklinikadi = 'Göz')
BEGIN
    INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('Göz', 'Geçerli', 'Göz hastalıkları');
END

GO

-- 2. İŞLEM ÖRNEKLERİ (Eğer yoksa)
IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'Muayene')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Muayene', '100');
END

IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'Kan Tahlili')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Kan Tahlili', '50');
END

IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'Röntgen')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Röntgen', '75');
END

IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'EKG')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('EKG', '80');
END

IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'Ultrason')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('Ultrason', '120');
END

IF NOT EXISTS (SELECT * FROM islem WHERE islemAdi = 'İdrar Tahlili')
BEGIN
    INSERT INTO islem (islemAdi, birimFiyat) VALUES ('İdrar Tahlili', '30');
END

GO

-- 3. KULLANICI ÖRNEKLERİ (Doktor ve Personel)
IF NOT EXISTS (SELECT * FROM kullanici WHERE kodu = '2')
BEGIN
    INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, username, unvan, ceptel) 
    VALUES ('2', 'Ahmet', 'Yılmaz', '1234', 'admin', 'ahmet', 'Doktor', '05551234567');
END

IF NOT EXISTS (SELECT * FROM kullanici WHERE kodu = '3')
BEGIN
    INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, username, unvan, ceptel) 
    VALUES ('3', 'Ayşe', 'Demir', '1234', 'pers', 'ayse', 'Hemşire', '05559876543');
END

IF NOT EXISTS (SELECT * FROM kullanici WHERE kodu = '4')
BEGIN
    INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, username, unvan, ceptel) 
    VALUES ('4', 'Mehmet', 'Kaya', '1234', 'admin', 'mehmet', 'Doktor', '05551112233');
END

IF NOT EXISTS (SELECT * FROM kullanici WHERE kodu = '5')
BEGIN
    INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, username, unvan, ceptel) 
    VALUES ('5', 'Fatma', 'Şahin', '1234', 'pers', 'fatma', 'Sekreter', '05554445566');
END

GO

-- 4. HASTA ÖRNEKLERİ
IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00001')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('1234567890', '00001', 'Ali', 'Veli', 'İstanbul', '1980-05-15', 'Hasan', 'Zeynep', 
            'Erkek', 'A+', 'Evli', 'İstanbul/Kadıköy', '02161234567', 'SGK001', 'SGK');
END

IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00002')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('2345678901', '00002', 'Zeynep', 'Kaya', 'Ankara', '1990-08-20', 'Mehmet', 'Ayşe', 
            'Kadın', 'B+', 'Bekar', 'Ankara/Çankaya', '03121234567', 'SGK002', 'SGK');
END

IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00003')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('3456789012', '00003', 'Mustafa', 'Öz', 'İzmir', '1975-03-10', 'Ali', 'Fatma', 
            'Erkek', '0+', 'Evli', 'İzmir/Konak', '02321234567', 'SGK003', 'SGK');
END

IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00004')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('4567890123', '00004', 'Elif', 'Yıldız', 'Bursa', '1985-11-25', 'Hüseyin', 'Hatice', 
            'Kadın', 'AB+', 'Evli', 'Bursa/Nilüfer', '02241234567', 'SGK004', 'SGK');
END

IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00005')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('5678901234', '00005', 'Can', 'Arslan', 'Antalya', '1995-07-08', 'Kemal', 'Selin', 
            'Erkek', 'A-', 'Bekar', 'Antalya/Muratpaşa', '02421234567', 'SGK005', 'SGK');
END

GO

-- 5. SEVK ÖRNEKLERİ (Hasta İşlemleri)
-- Bugünkü tarih için örnek sevkler
DECLARE @Bugun NVARCHAR(10) = CONVERT(NVARCHAR(10), GETDATE(), 120);

-- Hasta 00001 için işlemler
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00001' AND sevktarihi = @Bugun AND sira = '1')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00001', 'Genel Pratisyen', '09:00', 'Muayene', '2', '1', '100', '1', '100', 'Hayır');
END

IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00001' AND sevktarihi = @Bugun AND sira = '2')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00001', 'Genel Pratisyen', '09:30', 'Kan Tahlili', '2', '1', '50', '2', '50', 'Hayır');
END

-- Hasta 00002 için işlemler
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00002' AND sevktarihi = @Bugun AND sira = '1')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00002', 'Kardiyoloji', '10:00', 'EKG', '4', '1', '80', '1', '80', 'Hayır');
END

IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00002' AND sevktarihi = @Bugun AND sira = '2')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00002', 'Kardiyoloji', '10:15', 'Ultrason', '4', '1', '120', '2', '120', 'Hayır');
END

-- Hasta 00003 için işlemler
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00003' AND sevktarihi = @Bugun AND sira = '1')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00003', 'Ortopedi', '11:00', 'Röntgen', '2', '1', '75', '1', '75', 'Hayır');
END

-- Hasta 00004 için işlemler
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00004' AND sevktarihi = @Bugun AND sira = '1')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00004', 'Dahiliye', '14:00', 'Muayene', '4', '1', '100', '1', '100', 'Hayır');
END

IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00004' AND sevktarihi = @Bugun AND sira = '2')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00004', 'Dahiliye', '14:30', 'İdrar Tahlili', '4', '1', '30', '2', '30', 'Hayır');
END

-- Hasta 00005 için işlemler
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00005' AND sevktarihi = @Bugun AND sira = '1')
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Bugun, '00005', 'Göz', '15:00', 'Muayene', '2', '1', '100', '1', '100', 'Hayır');
END

GO

-- Önceki günler için örnek sevkler (taburcu edilmiş)
DECLARE @Dun NVARCHAR(10) = CONVERT(NVARCHAR(10), DATEADD(DAY, -1, GETDATE()), 120);
DECLARE @IkiGunOnce NVARCHAR(10) = CONVERT(NVARCHAR(10), DATEADD(DAY, -2, GETDATE()), 120);

-- Dün taburcu edilmiş hasta
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00001' AND sevktarihi = @Dun)
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@Dun, '00001', 'Genel Pratisyen', '10:00', 'Muayene', '2', '1', '100', '1', '100', 'Evet');
END

-- İki gün önce taburcu edilmiş hasta
IF NOT EXISTS (SELECT * FROM sevk WHERE dosyano = '00002' AND sevktarihi = @IkiGunOnce)
BEGIN
    INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu)
    VALUES (@IkiGunOnce, '00002', 'Kardiyoloji', '11:00', 'EKG', '4', '1', '80', '1', '80', 'Evet');
END

GO

PRINT 'Örnek veriler başarıyla eklendi!';
PRINT 'Poliklinikler: 5 adet';
PRINT 'İşlemler: 6 adet';
PRINT 'Kullanıcılar: 4 adet (admin zaten var)';
PRINT 'Hastalar: 5 adet';
PRINT 'Sevkler: Bugün için 8 adet, önceki günler için 2 adet';

