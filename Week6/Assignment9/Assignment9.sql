-- Soru 1: City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT city.city, country.country FROM city 
JOIN country ON country.country_id = city.country_id;

-- Soru 2: Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT payment.payment_id, customer.first_name, customer.last_name FROM payment
JOIN customer ON customer.customer_id = payment.customer_id;

-- Soru 3: Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT rental.rental_id, customer.first_name, customer.last_name 
FROM rental
JOIN customer ON customer.customer_id = rental.customer_id;