using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Class13.Configuration
{
    public class TitleFilter:IDocumentFilter
    {        
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Info.Title = "Task API";
        }
    }
}
