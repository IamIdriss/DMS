using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Dto
{
    public class DocumentDto

    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }

        //public PriorityLevel Priority { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public bool Done { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
