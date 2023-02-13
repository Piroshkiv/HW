using Microsoft.Extensions.Configuration;

namespace HW_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder();
            builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false);

            var configuration = builder.Build();

            var projectConfig = new Config();
            IConfigurationSection section = configuration.GetSection("Project");

            section.Bind(projectConfig);

            using (EmployeeContext context = new EmployeeContext(projectConfig.ConnectionString))
            {
                context.Titles.Add(new() { Name = "dsasda"});
                context.SaveChanges();
            }
            
        }
    }
}