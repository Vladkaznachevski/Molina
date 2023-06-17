using Data;
using Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.ClassRepo;
using Services.ClassSer;
using Repository.OrderRepo;
using Services.OrderSer;
using Repository.ShopCartRepo;
using Repository.ClothRepo;
using Services.ClothSer;
using Repository.MaterialRepo;
using Services.MaterialSer;
using Repository.SizeRepo;
using Services.SizeSer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));


builder.Services.AddScoped(typeof(IClassRepository), typeof(ClassRepository));
builder.Services.AddTransient<IClassService, ClassService>();

builder.Services.AddScoped(typeof(IClothRepository), typeof(ClothRepository));
builder.Services.AddTransient<IClothService, ClothService>();

builder.Services.AddScoped(typeof(IMaterialRepository), typeof(MaterialRepository));
builder.Services.AddTransient<IMaterialService, MaterialService>();

builder.Services.AddScoped(typeof(ISizeRepository), typeof(SizeRepository));
builder.Services.AddTransient<ISizeService, SizeService>();


builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
builder.Services.AddTransient<IOrderService, OrderService>();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCartRepository.GetCart(sp));
builder.Services.AddMemoryCache();
builder.Services.AddSession();


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
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
