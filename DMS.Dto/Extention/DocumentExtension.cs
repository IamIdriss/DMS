using DMS.Domain.Entities;

namespace DMS.Dto.Extention
{
    public static class DocumentExtension
    {

        public static DocumentDto ToDocumentDto(this Document document)
        {
            return new DocumentDto()
            {
                CategoryId = document.CategoryId,
                Name = document.Name,
                Content = document.Content,
                Id = document.Id,
                CategoryName = document.Category?.Name
            };
        }
        public static IEnumerable<DocumentDto> ToDocumentDtos(this IEnumerable<Document> documents)
        {
            var documentDtos = new List<DocumentDto>();
            foreach (var document in documents)
            {
                documentDtos.Add(document.ToDocumentDto());
            }
            return documentDtos;
        }

    }
}

