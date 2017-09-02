namespace DailyScrumWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(11)]
        public string NationalCode { get; set; }

        [Required]
        [StringLength(4000)]
        public string Password { get; set; }

        [StringLength(150)]
        public string Firstname { get; set; }

        [StringLength(150)]
        public string Lastname { get; set; }

        public bool IsScrumMaster { get; set; }

        public int? RelatedProjectId { get; set; }

        //[NotMapped]
        public virtual Project Project { get; set; }
    }
}
