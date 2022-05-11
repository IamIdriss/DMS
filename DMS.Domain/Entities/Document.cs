using DMS.Domain.Enums;

namespace DMS.Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public bool Done { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
