﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AQWithWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AQWDataEntities : DbContext
    {
        public AQWDataEntities()
            : base("name=AQWDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnswerTools> AnswerTools { get; set; }
        public virtual DbSet<IsOnline> IsOnline { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<LogInfo> LogInfo { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<S_GroupNumber> S_GroupNumber { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<Score_Type> Score_Type { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserHasToolsNumber> UserHasToolsNumber { get; set; }
    }
}
