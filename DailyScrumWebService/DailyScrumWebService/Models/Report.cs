namespace DailyScrumWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report
    {
        public long Id { get; set; }

        [Required]
        [StringLength(4000)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Submit { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        public virtual Project Project { get; set; }
    }
}
