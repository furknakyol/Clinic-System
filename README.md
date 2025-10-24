Bu proje, bir sağlık kliniğinin operasyonel süreçlerini (randevu, hasta, doktor, reçete yönetimi) dijitalleştirmek için tasarlanmış kapsamlı bir Klinik Yönetim Sistemi'nin backend ve veritabanı altyapısıdır.
Proje, kurumsal bir uygulama mimarisinin temellerini atmakta ve MS SQL Server 2022 üzerinde 3NF'ye göre normalleştirilmiş bir veri tabanı şeması üzerine kurulmuştur. Bu projenin birincil amacı, ileride bir İş Zekası (BI) projesine kaynaklık edecek zengin ve tutarlı bir operasyonel veri tabanı (OLTP) oluşturmaktır.

Kullanılan Teknolojiler:
Backend: C# (.NET)

Veritabanı: Microsoft SQL Server 2022 

ORM: Entity Framework Core (EF Core)

Projenin Mevcut Durumu (Tamamlanan Kısımlar):
Bu repository, projenin ilk geliştirme aşamalarını içermektedir.

Veritabanı Varlıkları (Entities): Sistemin temelini oluşturan tüm veri modelleri için C# sınıfları oluşturulmuştur.
Veri Tabanı Bağlamı (Context): Entity Framework Core için ClinicContext sınıfı hazırlanmıştır.
