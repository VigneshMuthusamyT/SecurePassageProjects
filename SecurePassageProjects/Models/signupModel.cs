using System.ComponentModel.DataAnnotations;

namespace SecurePassageProjects.Models
{
    public class signupModel
    {

        [Key]
        public int signupId { get; set; }

        public string UserName { get; set; }


        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }

        public List<GoogleModel> googleModels { get; set; }

        public List<FacebookModel> facebookModels { get; set; }

        public List<InstgramModel> instgramModels { get; set; }

        public List<BankingModel> bankingModels { get; set; }


    }

   
}
