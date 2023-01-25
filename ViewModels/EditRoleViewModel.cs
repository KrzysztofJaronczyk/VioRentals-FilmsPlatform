using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace VioRentals.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role name is required.")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
