using System.ComponentModel.DataAnnotations;

namespace Rize.Admin.Data.DTO.Store
{
    public class StoreShortDTO
    {
        public int StoreID { get; set; }
        [Display(Name = "Short Name")]
        public string? ShortName { get; set; }
        [Display(Name = "Description")]
        public string? StoDescription { get; set; }
        [Display(Name = "Code")]
        public string? StoCode { get; set; }
        [Display(Name = "Domain")]
        public string? StoDomain { get; set; }
        [Display(Name = "Web Titles")]
        public string? StoNameForWebPageTitles { get; set; }
        [Display(Name = "Allow AOP")]
        public bool? AllowAOP { get; set; }
        [Display(Name = "Template")]
        public string? LayoutTemplate { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
