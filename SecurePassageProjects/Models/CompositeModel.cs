namespace SecurePassageProjects.Models
{
    public class CompositeModel
    {

        //public GoogleModel GoogleModels { get; set; }

        //public InstgramModel InstgramModels { get; set; }

        //public FacebookModel FacebookModels { get; set; }

        //public BankingModel BankingModels { get; set; }

        public List<GoogleModel> GoogleModelss { get; set; }
        public List<FacebookModel> FacebookModelss { get; set; }
        public List<InstgramModel> InstagramModelss { get; set; }
        public List<BankingModel> BankingModelss { get; set; }

    }
}
