# Jaywashoe API

Sistem backend RESTful API untuk layanan cuci sepatu, dibangun menggunakan arsitektur standar enterprise.

**Tech Stack**
* Framework: C# & .NET 8 (ASP.NET Core Web API)
* ORM: Entity Framework Core (Code-First Migration)
* Database: SQL Server 
* Environment: Docker (Azure SQL Edge)

**Fitur Utama**
* Menggunakan arsitektur Controller-based.
* Implementasi Dependency Injection.
* Pemrosesan data secara Asynchronous (Async/Await).
* Endpoint manajemen Layanan (GET, POST) dan Pesanan (GET, POST, PUT).

**Cara Menjalankan Lokal**
1. Pastikan Docker menyala dan jalankan container database: `docker start jaywashoe-sql`
2. Lakukan sinkronisasi tabel: `dotnet ef database update`
3. Jalankan server: `dotnet run`
4. Buka Swagger di browser: `http://localhost:5154/swagger`
