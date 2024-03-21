using System.ComponentModel.DataAnnotations;

namespace SecurePassageProjects.Models
{
    public class BankingModel
    {

        [Key]
        public int bankId { get; set; }

        public string accounttype { get; set; }
        public string Bankname { get; set; }
        public string BankPhonenumber { get; set; }

        public string UPIPin { get; set; }


        public int? signupModelsignupId { get; set; }

        public signupModel signup { get; set; }
    }
}
