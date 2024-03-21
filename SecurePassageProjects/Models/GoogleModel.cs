using System.ComponentModel.DataAnnotations;

namespace SecurePassageProjects.Models
{
    public class GoogleModel
    {
        [Key]
        public int GoogleId { get; set; }

        public string Accounttypego { get; set; }
        public string GoogleuserName { get; set; }

        public string GooglePassword { get; set; }

        public int? signupModelsignupId { get; set; }

        public signupModel signup { get; set; }






    }
}
