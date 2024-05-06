using SimplePage.Data;
using SimplePage.Models;

namespace SimplePage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*var context = new AplicationDbContext();
            var employees = new []
            {
                new EmployeeModel()
                {
                  Name = "",
                  Age = 21,
                  Salary = 10000000000
                },
                new EmployeeModel()
                {
                  Name = "Ali",
                  Age = 21,
                  Salary = 5000
                },
                new EmployeeModel()
                {
                  Name = "Ahmed",
                  Age = 20,
                  Salary = 4000
                }, new EmployeeModel()
                {
                  Name = "omar",
                  Age = 21,
                  Salary = 7000
                }

            }.ToList();
            context.Employees.AddRange(employees);
            context.SaveChanges();

            */

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
