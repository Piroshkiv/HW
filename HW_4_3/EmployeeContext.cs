namespace HW_4_3
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(string connectionString = "Data Source=DESKTOP-NKSNT04;Initial Catalog=Employees;Integrated Security=True;") =>
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
            optionsBuilder.UseSqlServer(_connectionString);
        }
            
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmloyeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguretion());
            modelBuilder.ApplyConfiguration(new ProjectConfiguretion());
            modelBuilder.ApplyConfiguration(new TitleConfiguretion());

            modelBuilder.Entity<Client>().HasData(
                    new() { Id = 1, FirstName = "Artur", LastName = "Piroshkiv", Phone = "+380786847267", Email = "ArturPiroshkiv@gmail.com"},
                    new() { Id = 2, FirstName = "Ihor", LastName = "Jakirov", Phone = "+380987878783", Email = "IhorJakirov@gmail.com" },
                    new() { Id = 3, FirstName = "Daniil", LastName = "Morphovich", Phone = "+380926402640", Email = "DaniilMorphovich@gmail.com" },
                    new() { Id = 4, FirstName = "Maxim", LastName = "Nalivaiko", Phone = "+380027397293", Email = "MaximNalivaiko@gmail.com" },
                    new() { Id = 5, FirstName = "Denis", LastName = "Prolivaiko", Phone = "+380027397293", Email = "DenisProlivaiko@gmail.com" }
                    );

            modelBuilder.Entity<Project>().HasData(
                    new() { Id = 1, Name = "Name1", Budget = 8000, StartedDate = DateTime.Now, ClientId = 1 },
                    new() { Id = 2, Name = "Name2", Budget = 7000, StartedDate = DateTime.Now, ClientId = 1 },
                    new() { Id = 3, Name = "Name3", Budget = 9000, StartedDate = DateTime.Now, ClientId = 1 },
                    new() { Id = 4, Name = "Name4", Budget = 3000, StartedDate = DateTime.Now, ClientId = 1 },
                    new() { Id = 5, Name = "Name5", Budget = 10000, StartedDate = DateTime.Now, ClientId = 1 }
                );

        }
    }
}