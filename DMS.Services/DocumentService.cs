using DMS.Abstraction;
using DMS.Domain.Entities;

namespace DMS.Services
{
    public class DocumentService : IDocumentService
    {
        public Task AddDocumentAsync(Document document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDocumentAsync(int documentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Document>> GetAllDocumentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Document> GetDocumentByIdAsync(int documentId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDocumentAsync(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
