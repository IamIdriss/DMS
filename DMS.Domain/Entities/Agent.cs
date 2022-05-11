namespace DMS.Domain.Entities
{
    public class Agent
    {
        public int Id { get; set; }
        public string? LastName { get; set; } 
        public string? FirstName { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        
    }
}
