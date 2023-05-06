using _1.eTickers.Data;
using _1.eTickers.Data.Cart;
using _1.eTickers.Data.Services;
using _1.eTickers.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContex Configuration
// Thiết lập đường dẫn kết nối tới CSDL
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectString")));

// Service Configuration
// Thêm dịch vụ IActorsService và lớp triển khai ActorsService
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IProducersService, ProducersService>();
builder.Services.AddScoped<ICinemasService, CinemasService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();

// đăng ký dịch vụ HTTP khi khách hàng gửi yêu cầu request
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));



//Authentication and authorization

// Quản lý xác thực và phân quyền với lưu trữ bằng EntityFramworkCore
// ApplicationUser : Mô tả người truy dùng ; IdentityRole : mô tả quyền truy cập; AppDbContext : quản lý CSDL
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

// Lưu vào bộ nhớ tạm thời và tăng tốc độ truy xuất
builder.Services.AddMemoryCache();

// Lưu trữ phiên làm việc của người dùng
builder.Services.AddSession();

// Thiết lập giá trị mặc định của ứng dụng là CookieAuthenticationDefaults.AuthenticationScheme
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();


//Authentication & Authorization
app.UseAuthentication(); // Kiểm tra đăng nhập
app.UseAuthorization(); // Kiểm tra quyền

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");



// Seed database
AppDbInitializer.Seed(app);
AppDbInitializer.SeedUsersAndRoleAsync(app).Wait();


app.Run();
