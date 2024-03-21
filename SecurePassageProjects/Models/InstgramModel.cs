using System.ComponentModel.DataAnnotations;

namespace SecurePassageProjects.Models
{
    public class InstgramModel
    {


        [Key]
        public int InstaId { get; set; }

        public string AccounttypeIN { get; set; }
        public string INuserName { get; set; }

        public string INPassword { get; set; }

        public int? signupModelsignupId { get; set; }

        public signupModel signup { get; set; }
    }
}
