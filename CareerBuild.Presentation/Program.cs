using DataAccess.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CareerBuild.Presentation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			#region Add services to the container.
			// Add services to the container.
			builder.Services.AddControllersWithViews();

			//we need to add DBContext to DI Container
			builder.Services.AddDbContext<CareerBuildDbContext>(
			(options) =>
			{
				options.UseSqlServer(builder.Configuration
					.GetConnectionString("DefaultConnection"));
			});


			//and other service to be added to the DI Container
			#endregion

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			//To use HTTPS
			app.UseHttpsRedirection();

			//To make sure every static file is loaded if we used them in the routing
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
