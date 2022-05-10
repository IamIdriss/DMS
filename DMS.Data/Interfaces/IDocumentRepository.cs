using DMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Interfaces
{
    public interface IDocumentRepository
    {
        //PagedResult<Document> GetDocuments(string? name, int page);
        Task<Document?> GetDocument(int Id);
        Task<Document> AddDocument(Document upload);
        Task<Document?> UpdateDocument(Document upload);
        Task<Document?> DeleteDocument(int id);
    }
}
