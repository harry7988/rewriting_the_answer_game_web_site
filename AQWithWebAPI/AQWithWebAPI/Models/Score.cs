namespace AQWithWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ScoreID { get; set; }

        public int? S_Correct { get; set; }

        [StringLength(50)]
        public string S_Achieve_Date { get; set; }

        public int? S_GroupID { get; set; }

        public int? S_UserID { get; set; }

        public int? S_QID { get; set; }

        [StringLength(20)]
        public string S_Type { get; set; }

        public virtual Question Question { get; set; }

        public virtual S_GroupNumber S_GroupNumber { get; set; }

        public virtual Score_Type Score_Type { get; set; }

        public virtual User User { get; set; }
    }
}
