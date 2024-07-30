using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogForest.WebUI.Models
{
    public class UpdateRoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
