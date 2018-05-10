namespace AQWithWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogInfo")]
    public partial class LogInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InfoID { get; set; }

        [Required]
        [StringLength(10)]
        public string I_Msg { get; set; }

        [Required]
        [StringLength(10)]
        public string I_Date { get; set; }

        public int I_UserID { get; set; }

        [Required]
        [StringLength(10)]
        public string I_Type { get; set; }

        public virtual User User { get; set; }
    }
}
