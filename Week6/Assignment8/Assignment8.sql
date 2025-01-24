-- Soru 1: test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
    id SERIAL PRIMARY KEY, -- Serial'da integer değer oluşturur.
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);

-- Soru 2: Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
-- https://www.mockaroo.com üzerinden 50 adet veri oluşturuldu ve aşağıdaki insert sorgusu ile veritabanına eklendi.
insert into employee (name, email, birthday) values ('Bevin Jerzyk', 'bjerzyk0@oracle.com', '2019/04/17');

-- Soru 3: Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
UPDATE employee 
SET email = 'john.updated@oracle.com' 
WHERE name = 'John Doe';

UPDATE employee 
SET name = 'Updated Name' 
WHERE birthday < '1999-01-01'; -- 16 veri var.

-- Soru 4: Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM employee 
WHERE birthday < '1995-01-01'; -- 7 veri var.   