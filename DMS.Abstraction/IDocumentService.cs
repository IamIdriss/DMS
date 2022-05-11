using DMS.Domain.Entities;



namespace DMS.Abstraction
{
    public interface IDocumentService
    {
        public Task AddDocumentAsync(Document document);
        public Task UpdateDocumentAsync(Document document);
        public Task DeleteDocumentAsync(int documentId);
        public Task<IEnumerable<Document>> GetAllDocumentsAsync();
        public Task<Document> GetDocumentByIdAsync(int documentId);
    }
}
