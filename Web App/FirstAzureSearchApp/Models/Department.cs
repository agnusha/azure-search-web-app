using Azure.Search.Documents.Indexes;

namespace FirstAzureSearchApp.Models
{
    public partial class Department
    {
        [SearchableField]
        public string DepartmentID { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = false, IsFacetable = false)]
        public string Name { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = false, IsFacetable = false)]
        public string GroupName { get; set; }

        [SearchableField(IsFilterable = false, IsSortable = true, IsFacetable = false)]
        public string ModifiedDate { get; set; }
    }
}
