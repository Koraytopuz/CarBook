# Asp.Net Core Api 8.0 Onion Architecture ile CarBook Projesi
## Projenin Amacı;
Proje bir araç kiralama uygulamasıdır. Kullanıcılar lokasyona göre araçları filtreleyebilir ve seçilen araçlar için rezervasyon oluşturabilirler. Bununla birlikte blogları görüp okuyabilir, etiket sistemine, yazarlara ve kategorilere göre bloglarda listeleme yapabilmektedirler. Okudukları bloglara ve aldıkları araca yorum yapabilmektedirler. İletişim formundan sistem yöneticisine mesaj atabilmektedir. Bununla birlikte güçlü bir yönetim arayüzü olan uygulamada bütün bu sistem rol bazlı yönetim sistemiyle kontrol edilmektedir.
##  Kullanılan Bazı Teknolojiler
*  Onion Architecture mimarisiyle ve 
*  Proje CQRS ve Mediator Design Patterns üzerine kuruldu.
*  DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
*  Entity Framework 8.0 Veritabanı etkileşimi ve ORM için kullanıldı.
*  Blazor Framework ile geliştirilmiş Chatbot kullanılmıştır.
*  SignalR ile anlık veri güncellemesi sistemi projeye dahil edilmiştir.
*  Üyelik sistemi Jwt ile kontrol edilip rol bazlı yetkilendirme sağlanmıştır.
*  Bütün proje RESTful API' larla bütün CRUD işlemlerini yapabilir şekilde oluşturuldu.
*  Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır. 
*  Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
*  DTO katmanıyla veri yönetimi kolaylaştırıldı.
*  HTML-CSS Bootstrap ile arayüzler tasarlandı.
*  Fluent Validation - kontrol sistemi kullanılarak veirlerin belli kurallara göre alınması sağlandı.
*  Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
*  Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.
*  Adonet ve Linq Sorgular

##  Projedeki Bazı Ekran Görüntüleri
### Veritabanı
![image](https://github.com/user-attachments/assets/4cfb2433-ad06-48ac-9385-5cd66179669e)
### Giriş
![image](https://github.com/user-attachments/assets/810ed242-84f0-420b-902e-0ddaf717d487)
### Yeni Üyelik 
![image](https://github.com/user-attachments/assets/ade318af-73a0-41b6-bef1-823532af0bdf)
## Yönetim Paneli
### Dashboard
![image](https://github.com/user-attachments/assets/b3d491fe-dcc5-489c-989d-ec52dc65dc93)
### İstatistikler
![image](https://github.com/user-attachments/assets/ac0ea177-417b-4ebe-a4b1-51cdcfeac5b2)
### Araba İşlemleri
![image](https://github.com/user-attachments/assets/a348b514-ad8c-44c7-a2e0-59e9b81124df)
### Arabaya Özellik Ekleme İşlemi 
![image](https://github.com/user-attachments/assets/9efe265b-8708-4db6-91d5-9ae1a403d6bf)
### Araba Özellikleri
![image](https://github.com/user-attachments/assets/2bbd8b5f-0084-410f-948b-ff519fe1fb37)
### Markalar 
![image](https://github.com/user-attachments/assets/ac157b49-97d3-4f6c-a72c-7325a2242134)
### Blog İşlemleri 
![image](https://github.com/user-attachments/assets/fc218736-dca9-4564-acef-8e3c6c7b129b)
### Rezervasyon İşlemleri
![image](https://github.com/user-attachments/assets/74c7670b-ba93-48f8-b571-079b1e781af9)
### Blog İşlemleri
![image](https://github.com/user-attachments/assets/5a6ed882-3249-4b86-96f6-89740b3e1876)
### Lokasyonlar 
![image](https://github.com/user-attachments/assets/33c548a9-df68-4441-8fbd-4561de3d3335)
### Referanslar
![image](https://github.com/user-attachments/assets/55b41ba4-9005-4107-b74d-4dbe05e18816)
## Ana Ekran 
![image](https://github.com/user-attachments/assets/536dbdf4-812d-428d-8bad-35950f9ee33f)
![image](https://github.com/user-attachments/assets/b415d332-670e-44e9-9d92-3837e83fbd5c)
![image](https://github.com/user-attachments/assets/4cde7be0-b9ba-4f29-93eb-8fa34360e6e9)
![image](https://github.com/user-attachments/assets/9c94bbe9-5f2d-41b6-a00d-0ddcbfc55ae3)
![image](https://github.com/user-attachments/assets/92908053-327a-4965-9bb0-893dbf0f083d)
![image](https://github.com/user-attachments/assets/2e7cafc9-d77d-4d4a-8307-de8060006328)

### Ana Ekran Chatbot
![image](https://github.com/user-attachments/assets/53390dd5-42e3-4cec-8939-7e2a862c001e)
### Fiyatlar
![image](https://github.com/user-attachments/assets/2efbf5d5-2db9-4aa4-997a-4468b2f3336b)
### Arabalar
![image](https://github.com/user-attachments/assets/a28fe975-c68d-4c23-9b89-f27425550a83)
![image](https://github.com/user-attachments/assets/f4470015-c0b9-4e82-bf2a-4fa7b5156aa4)
![image](https://github.com/user-attachments/assets/855a290d-2c51-4426-9ac6-22f4e2c89f3a)
### Bloglar
![image](https://github.com/user-attachments/assets/00949ca9-f0b6-4ac1-9859-0137eaedf092)
### Rezervasyon İşlemi
![image](https://github.com/user-attachments/assets/ce8e0364-e662-44f7-8268-8a42963de349)
### İletişim 
![image](https://github.com/user-attachments/assets/9f42b1d9-1365-4e4f-8a0c-d133e6b45288)























