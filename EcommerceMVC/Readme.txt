1-) Öncelikle katlamlar yaratılacak
2-) Entityler ve DbContext oluşturulacak ( Core katmanında Entityler, Data katmanında DbContext) , Data katmanına nuGet olarak Microsoft.EntityFrameworkCore ve Microsoft.EntityFrameworkCore.SqlServer eklenmeli
PMC Command	Usage
Add-Migration	Adds a new migration.
Bundle-Migration	Creates an executable to update the database.
Drop-Database	Drops the database.
Get-DbContext	Gets information about a DbContext type.
Get-Help EntityFramework	Displays information about Entity Framework commands.
Get-Migration	Lists available migrations.
Optimize-DbContext	Generates a compiled version of the model used by the DbContext.
Remove-Migration	Removes the last migration.
Scaffold-DbContext	Generates a DbContext and entity type classes for a specified database.
Script-DbContext	Generates a SQL script from the DbContext. Bypasses any migrations.
Script-Migration	Generates a SQL script from the migrations.
Update-Database	Updates the database to the last migration or to a specified migration.
3-) DBContext dosyasını tamamlayınca, Package Manager Console'dan "Add-Migration InitialCreate" komutunu çalıştırarak ilk migration'ı oluştur.
4-) Ardından "Update-Database" komutunu çalıştırarak veritabanını oluştur.