USE SOHATS;
GO

-- Dosya No 00006 için hasta kaydı ekle
-- (Sevk zaten var, sadece hasta kaydı eksik)

IF NOT EXISTS (SELECT * FROM hasta WHERE dosyano = '00006')
BEGIN
    INSERT INTO hasta (tcKimlikNo, dosyano, ad, soyad, dogumyeri, dogumtarihi, babadi, anneadi, 
                       cinsiyet, kangubu, medenihal, adres, tel, kurumsicilno, kurumadi)
    VALUES ('6789012345', '00006', 'Yeni', 'Hasta', 'İstanbul', '1990-01-15', 'Baba', 'Anne', 
            'Erkek', 'A+', 'Bekar', 'İstanbul/Beşiktaş', '02121234567', 'SGK006', 'SGK');
    
    PRINT 'Hasta kaydı başarıyla eklendi: Dosya No 00006';
END
ELSE
BEGIN
    PRINT 'Hasta kaydı zaten mevcut: Dosya No 00006';
END

GO

-- Kontrol: Hasta ve sevk kayıtlarını göster
SELECT 
    h.dosyano AS [Dosya No],
    h.ad + ' ' + h.soyad AS [Hasta Adı],
    COUNT(s.dosyano) AS [Sevk Sayısı]
FROM hasta h
LEFT JOIN sevk s ON h.dosyano = s.dosyano AND s.taburcu = 'Hayır'
WHERE h.dosyano = '00006'
GROUP BY h.dosyano, h.ad, h.soyad;

GO

-- Bu hastanın sevklerini göster
SELECT 
    sevktarihi AS [Tarih],
    poliklinik AS [Poliklinik],
    yapilanislem AS [İşlem],
    toplamtutar AS [Tutar],
    taburcu AS [Taburcu]
FROM sevk
WHERE dosyano = '00006'
ORDER BY sevktarihi DESC, sira;

GO





