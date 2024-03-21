using System.ComponentModel.DataAnnotations;

namespace SecurePassageProjects.Models
{
    public class FacebookModel
    {



        [Key]
        public int FacebookId { get; set; }

        public string AccounttypeFb { get; set; }
        public string FBuserName { get; set; }

        public string FBPassword { get; set; }

        public int? signupModelsignupId { get; set; }

        public signupModel signup { get; set; }

    }
}
