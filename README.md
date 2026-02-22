# Sinama-Yonetim-sistemi-CRUD
Bu proje modern yazılım geliştirme prensiplerini ve .NET ekosistemindeki güncel yaklaşımları uygulamalı olarak göstermek amacıyla geliştirilmiştir.
Kullanılan Teknolojiler ve Mimari Yaklaşımlar:
.NET 8+ ve WinForms: Uygulama arayüzü ve çalışma ortamı.
Entity Framework Core, Code First Yaklaşımı: SQL Server entegrasyonu ve veritabanı yönetimi.
Asenkron Programlama: Veritabanı işlemleri Task tabanlı async ve await yapısı ile gerçekleştirilerek UI thread yönetimi optimize edilmiştir.
SOLID Prensipleri: Proje yapısı sürdürülebilir ve genişletilebilir olması adına SOLID prensiplerine uygun tasarlanmıştır.

Proje Yapısı:
Abstract: Interfaceler ve soyut tanımlamalar (IEntityRepository, IFilmService, IYonetmenService vb.)
Concrete: İş mantığı sınıfları ve DbContext implementasyonları.
Models: Veritabanı tablolarını temsil eden Entity sınıfları.
