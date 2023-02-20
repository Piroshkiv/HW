namespace HW_4_3
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(string connectionString = "Data Source=DESKTOP-DQSJ5BV;Initial Catalog=Employees;Integrated Security=True;") =>
            _connectionString = connectionString;

        private string _connectionString;

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(s => Console.WriteLine(s), Microsoft.Extensions.Logging.LogLevel.Information ).UseSqlServer(_connectionString);
        }
            
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmloyeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguretion());
            modelBuilder.ApplyConfiguration(new ProjectConfiguretion());
            modelBuilder.ApplyConfiguration(new TitleConfiguretion());

            
        }
    }
}