Package Manager Console
cd EcommerceBlazorAPI

dotnet ef migrations add CreateInitial
dotnet ef database update

dotnet ef migrations add SeedingData
dotnet ef database update

