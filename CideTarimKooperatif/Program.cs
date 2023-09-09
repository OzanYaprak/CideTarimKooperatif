using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;

namespace CideTarimKooperatif
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IServiceService, ServiceManager>();
            builder.Services.AddScoped<IServiceDAL,EFServiceDAL>();

            builder.Services.AddScoped<ITeamService, TeamManager>();
            builder.Services.AddScoped<ITeamDAL, EFTeamDAL>();

            builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            builder.Services.AddScoped<IAnnouncementDAL, EFAnnouncementDAL>();

            builder.Services.AddScoped<IImageService, ImageManager>();
            builder.Services.AddScoped<IImageDAL, EFImageDAL>();

            builder.Services.AddScoped<IAddressService, AddressManager>();
            builder.Services.AddScoped<IAddressDAL, EFAddressDAL>();

            builder.Services.AddScoped<IContactService, ContactManager>();
            builder.Services.AddScoped<IContactDAL, EFContactDAL>();

            builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
            builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();

            builder.Services.AddDbContext<CideTarýmDB>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}