using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Diagnostics.Metrics;

namespace OData.Models
{
    public static class EdmModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();

            modelBuilder.EntitySet<Gadgets>("Gadgets");

            return modelBuilder.GetEdmModel();
        }
    }
}
