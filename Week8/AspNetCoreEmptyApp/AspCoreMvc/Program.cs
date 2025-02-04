var builder = WebApplication.CreateBuilder(args);

// MVC Servislerini ekleme
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyaları kullanabilmek için ekleme
app.UseStaticFiles();

// Routing yapılandırması
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();

// Controller: Kullanıcıdan gelen isteği işler ve uygun bir View'e yönlendirir.

// Action: Bir Controller içinde bulunan ve kullanıcının çağırabileceği bir metottur.

// Model: Verileri temsil eden sınıflardır. Veritabanı veya iş mantığı ile ilgili işlemler burada yapılır.

// View: Kullanıcıya gösterilecek HTML sayfalarıdır.

// Razor: ASP.NET Core içinde kullanılan şablonlama motorudur. C# ile HTML iç içe kullanılabilir.

// RazorView: Razor ile oluşturulmuş, dinamik içerik üreten bir View türüdür.

// wwwroot: Statik dosyaların (CSS, JS, resimler) tutulduğu klasördür.

// builder.Build(): Uygulama yapılandırmasını tamamlar ve bir WebApplication nesnesi oluşturur.

// app.Run(): Uygulamayı çalıştırır ve HTTP isteklerini dinlemeye başlar.