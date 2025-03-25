# 📚 Patika Library

This project is designed to create a book registration application for the Patika Library. In this phase, we aim to create book objects with specific details.

## 📋 Requirements
1. **Book Properties**

    Each book should include the following properties:
- Title (Book name) 📖
- Author First Name (Author's first name) 🖋️
- Author Last Name (Author's last name) 🖋️
- PageCount (Number of pages) 📄
- Publisher (Publishing house) 🏢
- RegistrationDate (The date the book is registered) 🗓️

2. **Constructors**

The class should include two constructor alternatives:

- Default Constructor:
    - Works without parameters. 
    - Automatically assigns the RegistrationDate to the current date and time (DateTime.Now).
- Parameterized Constructor:
    - Accepts parameters to initialize the following properties:
        -  Title, AuthorFirstName, AuthorLastName, PageCount, Publisher.
- Automatically assigns the RegistrationDate to the current date and time (DateTime.Now).

## ✨ Example Output
```bash
Kitap kaydedildi! (Default Constructor)
Kitap Adı: Bilinmiyor, Yazar: Bilinmiyor Bilinmiyor, Sayfa Sayısı: 0, Yayınevi: Bilinmiyor, Kayıt Tarihi: 1/9/2025 8:54:11 AM

Kitap kaydedildi! (Parametreli Constructor)
Kitap Adı: Kimlik, Yazar: Milen Kundera, Sayfa Sayısı: 136, Yayınevi: Can Yayınları, Kayıt Tarihi: 1/9/2025 8:54:11 AM
```