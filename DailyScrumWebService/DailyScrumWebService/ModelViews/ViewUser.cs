namespace DailyScrumWebService.ModelViews
{

    public partial class ViewUser
    {
        public string Username { get; set; }

        public string NationalCode { get; set; }

 
        public string Password { get; set; }

 
        public string Firstname { get; set; }


        public string Lastname { get; set; }

        public bool IsScrumMaster { get; set; }

        public int? RelatedProjectId { get; set; }
    }
}
