using System;

namespace DailyScrumWebService.ModelViews
{

    public partial class ViewReport
    {
        public long Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }


        public DateTime Submit { get; set; }

        public int ProjectId { get; set; }

        public string Username { get; set; }

    }
}
