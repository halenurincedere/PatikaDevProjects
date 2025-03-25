-- Soru 1: Country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.
SELECT * FROM country
WHERE country LIKE 'A%a';

-- Soru 2: country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.
SELECT * FROM country
WHERE country LIKE '_____%n'; -- videodakine bağlı kalmak istediğim için bu şekilde yazdım.
-- Daha Mantıklı Olan: 
WHERE LENGTH(country) >= 6 AND country LIKE '%n';

--  Soru 3: Film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.
SELECT title FROM film 
WHERE title ILIKE '%T%'
LIMIT 10 OFFSET 4; -- 580 toplam sonuç vardı.Kendim bir aralık vermek istedim. Gösterilmediği için diğer sonuçları bu tarz bir şekilde kullanmak istedim.

-- Soru 4: Film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.
SELECT * FROM film
WHERE title LIKE 'C%' AND length(title) > 90 AND rental_rate = 2.99;