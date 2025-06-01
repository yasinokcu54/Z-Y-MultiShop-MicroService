# Z&Y MultiShop MicroService
 Çok sayıda mikroservisin bir arada çalıştığı "Z&Y MultiShop E-Ticaret" projesini başarıyla bitirdim. 
Bu projede kullanıcılar: 
	Ürünleri keşfederek sepetlerine ekleyebilir, 
	Güvenli bir şekilde sipariş oluşturabilir, 
	Siparişlerini kullanıcı panelinden takip edebilir.
	Yöneticiye mesaj atabilir.
	Ürünlere yorum yapabilir.
Yöneticiler ise: 
	Ürün ve kategori yönetimi, 
	Kargo seçenekleri ekleme, 
	Canlı site istatistiklerini takip etme gibi işlemleri gerçekleştirebilir.
	Yeni ürün ekleyebilir, güncelleyebilir.
	Kampanyaları ve indirimleri düzenleyebilir.

- ASP.NET Core 6.0 ile geliştirilen projede mikroservis yapısı,  N katmanlı ve Onion mimarileriyle işlenmiş, Repository, CQRS ve Mediator desenleri uygulanmıştır.
- Veritabanı yönetimi Docker ile sağlanmış olup, MSSQL, MongoDB, Redis ve PostgreSQL veritabanları kullanılmıştır. 
- Ocelot Gateway Mikro hizmet mimarilerinin karmaşıklığını azaltmak ve API yönetimini büyük ölçüde kolaylaştırmak için kullanılmıştır.
- API'leri test etmek amacıyla Postman ve Swagger araçları kullanılmıştır.
- Uygulamanın yalnızca yerel ortamda çalışmakla sınırlı kalmaması ve farklı platformlarda sorunsuzca çalışabilmesi için Docker kullanıp arayüz olarak da Portainer'den yönetim sağlanmıştır.
- Localization kullanılarak uygulamanın çoklu dil yapısı kullanıcı tercihine göre sunulmuştur. 
- RabbitMQ uygulama içi mesaj atma görevini üstenmektedir.
- Projenin güvenlik kısmı, Identity ve JWT (JSON Web Token) ile sağlanmıştır.
- RapidAPI projeye dahil edilerek güncel kur bilgileri, kullanıcın bulunduğu şehire göre hava durumu gibi verilerin çekilmesinde kullanılmıştır.

Backend Teknolojileri
	Asp.Net Core 6.0
	Asp.Net Web API
	Dapper
	IdentityServer4
	RabbitMQ
	Ocelot Gateway
	Json Web Token


Mikroservisler ve Veritabanları
	Basket -  Redis
	Cargo -  MSSQL
	Catalog - MongoDb
	Comment -  MSSQL
	Discount - Local MSSQL Dapper
	Images - Local SQL
	Message - PostgreSQL
	Order -  MSSQL
	IdentityServer4 -  MSSQL
	Payment - RabbitMQ
	SignalR
	RapidApi

Altyapı ve Araçlar
	Docker
	DBeaver
	Postman
	Swagger
	RapidApi

Mimari ve Tasarım Desenleri
	Onion Architecture
	CQRS Design Pattern
	Mediator Design Pattern
	Repository Design Pattern

Frontend Teknolojileri
	Html
	Css
	JavaScript
	Bootstrap

