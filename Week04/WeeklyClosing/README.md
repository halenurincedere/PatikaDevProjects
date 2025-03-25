# Weekly Closing
💣Hafta 4 - Kapanış
Bir teknoloji mağazasında Telefon ve Bilgisayar kayıtları alıyoruz.

Telefon -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Tr Lisanslı olup olmama durumu özelliklerine sahip.

Bilgisayar -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Usb Giriş Sayısı, Bluetooth olup olmama durumu özelliklerini sahip

BaseMakine isminde bir BaseClass'tan Telefon ve Bilgisayar classlarına miras veriniz. (Inheritance)
Bilgisayar için Usb giriş sayısı 2 veya 4 atanabilir, aksi durumda bir uyarı mesajı verilerek -1 değeri atansın. (Encapsulation)
Üretim Tarihi değeri bir nesne oluşturulduğu anda otomatik olarak atansın. Telefon için de Bilgisayar için de geçerli.
Base Class içerisinde (BaseMakine) Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi gibi ortak olan bilgileri yazdıran bir BilgileriYazdir() metodu tanımlansın. Derived classlarda (Telefon, Bilgisayar) bu metot ezilerrek Base işlevinin üzerine kendilerine ait olan özelliklerinde yazdırılma işlevi eklensin.   (Polymorphism)
UrunAdiGetir() diye abstract bir metot tanımlayarak Telefon ve Bilgisayar için ayrı ayrı ezerek

"Telefonunuzun adı ---> ......"

"Bilgisayarınızın adı ---> ......"

şeklinde konsol mesajları yazdırılabilsin.  (Abstraction)

Program akışı:

1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.

2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.

3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek isteyip istemediğini sorunuz.

4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek uygulamayı sonlandırınız.
