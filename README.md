# 💼 CorporateWebSite

Kurumsal teknoloji şirketleri için hazırlanmış çok katmanlı bir ASP.NET Core MVC projesidir.  
Hem kullanıcılar hem de yöneticiler için iki ayrı panel içermektedir.

---

## 🚀 Kullanılan Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core
- Microsoft SQL Server
- Katmanlı Mimari (Layered Architecture)

---

## 👥 Kullanıcı Paneli Özellikleri

- Ana Sayfa
- Hakkımızda
- Projeler
- Ekibimiz
- Kariyer
- Kullanıcı Giriş Sistemi (veritabanı destekli)
- İş Başvuru Formu (veritabanına kayıt)
- Footer üzerinden Görüş ve Öneri Gönderimi (veritabanına kayıt)

📸 Örnek Görseller:
- **Ana Sayfa**  
  ![Ana Sayfa](screenshots/user/home.png)

- **Giriş Sayfası**  
  ![Giriş Sayfası](screenshots/user/login.png)

- **İş Başvuru Formu**  
  ![İş Başvurusu](screenshots/user/job-application.png)

---

## 🛠️ Admin Paneli Özellikleri

- Anasayfa yönetimi
- Hakkımızda içerik güncelleme
- Projeler Ekle / Güncelle / Sil
- Ekibimiz bilgilerini düzenleme
- Kariyer alanını yönetme
- Kullanıcı Başvurularını Görüntüleme
- Gelen Görüş & Önerileri Görüntüleme ve Yönetme

📸 Örnek Görseller:
- **Admin Dashboard**  
  ![Dashboard](screenshots/admin/dashboard.png)

- **Projeler Yönetimi**  
  ![Projeler](screenshots/admin/projects.png)

---

## ⚙️ Veritabanı Hakkında

Projede kullanılan veriler SQL Server veritabanında tutulmaktadır.  
Veritabanı, Entity Framework Migration komutlarıyla yeniden oluşturulabilir:

```bash
dotnet ef database update
