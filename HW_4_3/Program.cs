using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;

namespace HW_4_3
{
    internal class Program
    {
        private static Config _config;
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false);

            var configuration = builder.Build();

            _config = new Config();
            IConfigurationSection section = configuration.GetSection("Project");

            section.Bind(_config);

            new EmployeeContext(_config.ConnectionString);



            EmploeeJoin();
            HiredDateLambda();
            BudgetIncrease(1, 1200);
            AddEmployee(new Employee()
            {
                FirstName = "name1",
                LastName = "name2",
                DateOfBirth = DateTime.Today,
                HiredDate = DateTime.Today,
                Title = new Title() { Name = "name1" },
                Office = new Office() { Title = "title1", Location = "loc1" }
            });

            DeleteEmployeeById(2);

            GroupEmployee();
        }

        static void EmploeeJoin()
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            
                db.ChangeTracker.AutoDetectChangesEnabled = false;

                var data = (from e in db.Employees
                            join t in db.Titles
                             on e.TitleId equals t.Id into ET
                            from res1 in ET.DefaultIfEmpty()
                            join o in db.Offices
                            on e.OfficeId equals o.Id into EI
                            from res2 in EI.DefaultIfEmpty()
                            select new
                            {
                                EmployeeId = e.Id,
                                Title = res1.Name,
                                Office = res2.Title
                            }).ToList();
            
        }

        static void HiredDateLambda()
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            db.ChangeTracker.AutoDetectChangesEnabled = false;

            _ = db.Employees.Select(e => e.HiredDate - DateTime.Today).ToList();
            
        }
        static void BudgetIncrease(int ProjectId, decimal increase)
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            using var transaction = db.Database.BeginTransaction();
            try
            {
                var emlpoees = db.Projects.First(p => p.Id == ProjectId);
                transaction.CreateSavepoint("beforeIncrease");
                emlpoees.Budget += increase;
                var number = emlpoees.EmployeeProjects.Count();
                emlpoees.EmployeeProjects.ToList().ForEach(e => e.Rate += increase / number);
                db.SaveChanges();
                transaction.Commit();
            }
            catch(Exception ex)
            {
                transaction.RollbackToSavepoint("beforeIncrease");
            }

        }
        static void AddEmployee(Employee employee)
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            db.Add(employee);
            db.SaveChanges();
        }
        static void DeleteEmployeeById(int EmployeeId)
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            db.Remove(new Employee { Id = EmployeeId });
            db.SaveChanges();
        }

        static void GroupEmployee()
        {
            using EmployeeContext db = new EmployeeContext(_config.ConnectionString);
            db.ChangeTracker.AutoDetectChangesEnabled = false;

            _ = db.Employees.GroupBy(e => e.Title.Name ).Where(e => !e.Key.Contains("a")).Select(e => new { key = e.Key, count = e.Count() } ).ToList();

        }

    }
}