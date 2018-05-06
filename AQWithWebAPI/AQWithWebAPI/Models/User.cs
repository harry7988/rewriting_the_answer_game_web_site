namespace AQWithWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            LogInfo = new HashSet<LogInfo>();
            S_GroupNumber = new HashSet<S_GroupNumber>();
            Score = new HashSet<Score>();
            UserHasToolsNumber = new HashSet<UserHasToolsNumber>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Passwords { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int LevelID { get; set; }

        public int? Max_score { get; set; }

        public int? RloeID { get; set; }

        [StringLength(20)]
        public string IsOnline { get; set; }

        [StringLength(50)]
        public string Add_Date { get; set; }

        public virtual IsOnline IsOnline1 { get; set; }

        public virtual Level Level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogInfo> LogInfo { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_GroupNumber> S_GroupNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Score { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserHasToolsNumber> UserHasToolsNumber { get; set; }
    }
}
