namespace AQWithWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHasToolsNumber")]
    public partial class UserHasToolsNumber
    {
        public int ID { get; set; }

        public int ToolID { get; set; }

        public int UserID { get; set; }

        public int ToolsNumber { get; set; }

        public virtual AnswerTools AnswerTools { get; set; }

        public virtual User User { get; set; }
    }
}
