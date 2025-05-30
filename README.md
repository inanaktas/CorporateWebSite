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

📸 Kullanıcı (User) Görseller:
- **Ana Sayfa**  
  ![Ana Sayfa](CW.WebUI/wwwroot/screenshots/user/homepage.png)
  Her eklenen fotoğraf bir sağa bir sola şeklinde gelir. Ve yanına ilgili yazı bilgisi yazılır

- **Hakkımızda**  
  ![Hakkımızda](CW.WebUI/wwwroot/screenshots/user/aboutUs.png)

- **Projeler-1**  
  ![Projeler](CW.WebUI/wwwroot/screenshots/user/project_1.png)
  Proje sayfası. Admin  tarafından eklendikçe 3 er li şekilde gelir.
  Daha fazla butona basıldığında ayrıntısı modal şeklinde çıkar.

  **Projeler-2**  
  ![Projeler](CW.WebUI/wwwroot/screenshots/user/project_2.png)  
  Daha fazla butona basıldığında ayrıntısı modal şeklinde çıkar.

  **Ekibimiz**  
  ![Ekibimiz](CW.WebUI/wwwroot/screenshots/user/teams.png)  
  Ekibimiz sayfası. Admin  tarafından eklendikçe 3 er li şekilde kişiler gelir.
  Eğer admin sayfasında ilgili kişi pasif işaretlendi ise silinmez ama user sayfasında gözükmez.
  Aktif olarak değiştirilirse tekrar gözükür.

  **Kariyer**  
  ![Kariyer](CW.WebUI/wwwroot/screenshots/user/career.png)
  Kariyer sayfası. 3 birim için iş başvurusu. Birimler veritabanından gelmektedir.
  Başvur kısmına tıklanında başvuru formuna gider.

  **İş Başvuru Formu(Dinamik)**  
  ![Başvuru](CW.WebUI/wwwroot/screenshots/user/application.png)
  Formda pozisyon-deneyim süresi veritabanından gelmektedir.bu bilgiler tablo oluşturularak değil DB ye elle girilmiştir.
  Bilgisayar bilgisi kısmı tik olarak çoklu seçime uygundur. DB ye kayıt edilir.
  Tüm bunlar ilişkili tablo olarak many to many olarak oluşturulmuştur.


  **Görüş ve Öneri Formu**  
  ![Öneri](CW.WebUI/wwwroot/screenshots/user/feedback.png)
  Görüş ve Öneri Formu. Daha da geliştirilebilir. Formdaki kayıtlar veritabanına kayıt edilir.
  

---

## 🛠️ Admin Paneli Özellikleri

- Anasayfa yönetimi
- Hakkımızda içerik güncelleme
- Projeler Ekle / Güncelle / Sil
- Ekibimiz bilgilerini düzenleme
- Kariyer alanını yönetme
- Kullanıcı Başvurularını Görüntüleme
- Gelen Görüş & Önerileri Görüntüleme ve Yönetme

📸 Admin Görseller:
- **Admin Anasayfa**  
  ![Anasayfa](CW.WebUI/wwwroot/screenshots/admin/homepagecontrol.png)
  Kaydetme-ekleme-silme ve güncelleme-fotoğraf ekleme- veritabanına kayıt işlemi

- **Hakkımızda**  
  ![Hakkımızda](CW.WebUI/wwwroot/screenshots/admin/aboutuscontrol.png)
  Kaydetme-ekleme-silme ve güncelleme-fotoğraf ekleme- veritabanına kayıt işlemi
  Fotoğraf yükle denilince önizleme oluşturulur.

  **Projeler**  
  ![Projeler](CW.WebUI/wwwroot/screenshots/admin/projects.png)
  Kaydetme-ekleme-silme ve güncelleme-fotoğraf ekleme- veritabanına kayıt işlemi
  Proje ismine tarihine göre sorgulama veya tüm listeyi getirme.

  **Ekibimiz**  
  ![Ekibimiz](CW.WebUI/wwwroot/screenshots/admin/teams.png)
  Kaydetme-ekleme-silme ve güncelleme-fotoğraf ekleme- veritabanına kayıt işlemi
  Pasif aktif butonu
  Güncelle denildiğinde aktif olan veri pasif işaretlenirse veri silinmez ama user sayfasında gözükmez.
  Silmek istenildiğinde tamamen silinir.
  Pasif olan veri güncelle denilerek tekrar aktif yapılabilir.

  **Kariyer**  
  ![Kariyer](CW.WebUI/wwwroot/screenshots/admin/careercontrol.png)
  Kaydetme-ekleme-silme ve güncelleme-fotoğraf ekleme- veritabanına kayıt işlemi
  Bu kısım anasayfada gözükecek bilgilerin girişi içindir iş başvuru kısmı değildir.  

  **Başvurular**  
  ![Başvurular](CW.WebUI/wwwroot/screenshots/admin/applications.png)
  Başvuru formunu dolduran kişilerin tüm listesi gelir.
  Tercihen herhangi önemli bir birim için kırmızı başvurular önemlidir.
  Burada backend acil aranan ilandır ve kırmızıdır.

  **Görüş ve Öneriler**  
  ![Öneriler](CW.WebUI/wwwroot/screenshots/admin/feedback.png)
  İki tablo vardır. Müşteri beklentileri şikayetleri bildirimleridir.
  Okundu ve işlem yaptı butonları vardır.
  Okundu ise üst tabloda kalır eğer beklemede kısmına tıklanırsa iş bitmiştir ve alt tabloya düşer.
  

---

## ⚙️ Veritabanı Hakkında

Projede kullanılan veriler SQL Server veritabanında tutulmaktadır.  
Veritabanı, Entity Framework Migration komutlarıyla yeniden oluşturulabilir:
Veritabanı bilgileri gönderilmemiştir.

```bash
dotnet ef database update
