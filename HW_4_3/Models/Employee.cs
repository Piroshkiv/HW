namespace HW_4_3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int OfficeId { get; set; }
        public int TitleId { get; set; }

        public Office Office { get; set; }
        public Title Title { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
