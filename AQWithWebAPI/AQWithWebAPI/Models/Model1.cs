namespace AQWithWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerTools>()
                .HasMany(e => e.UserHasToolsNumber)
                .WithRequired(e => e.AnswerTools)
                .HasForeignKey(e => e.ToolID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IsOnline>()
                .Property(e => e.Desc)
                .IsFixedLength();

            modelBuilder.Entity<IsOnline>()
                .HasMany(e => e.User)
                .WithRequired(e => e.IsOnline1)
                .HasForeignKey(e => e.IsOnline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogInfo>()
                .Property(e => e.I_Msg)
                .IsFixedLength();

            modelBuilder.Entity<LogInfo>()
                .Property(e => e.I_Date)
                .IsFixedLength();

            modelBuilder.Entity<LogInfo>()
                .Property(e => e.I_Type)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.Question)
                .HasForeignKey(e => e.S_QID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RloeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_GroupNumber>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.S_GroupNumber)
                .HasForeignKey(e => e.S_GroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Score_Type>()
                .Property(e => e.Desc)
                .IsFixedLength();

            modelBuilder.Entity<Score_Type>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.Score_Type)
                .HasForeignKey(e => e.S_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LogInfo)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.I_UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.S_GroupNumber)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.S_UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserHasToolsNumber)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
