namespace DMS.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Abbrevation { get; set; }
        public string? City { get; set; }
        public ICollection<Agent>? Agents { get; set; }
    }
}
