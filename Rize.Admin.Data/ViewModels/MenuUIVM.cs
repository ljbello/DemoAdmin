using Telerik.SvgIcons;

namespace Rize.Admin.Data.ViewModels
{
    public class MenuUIVM
    {
        public int TreeNodeID { get; set; }
        public int NodeOrder { get; set; }
        public int NodeLevel { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> PageID { get; set; }
        public Nullable<int> ParentTreeNodeID { get; set; }
        public string NodeIconID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string Url { get; set; }
        public Nullable<int> MenuType { get; set; }
        public string ExternalUrl { get; set; }
        public string ScriptCode { get; set; }

        public virtual ICollection<MenuUIVM> Submenus { get; set; }
    }
}
