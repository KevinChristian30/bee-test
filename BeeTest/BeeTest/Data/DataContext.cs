using BeeTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Participant_Schedule> Participant_Schedules { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TemporaryAnswers> TemporaryAnswers { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant_Schedule>()
                .HasKey(ps => new { ps.ParticipantId, ps.ScheduleId });
            modelBuilder.Entity<Participant_Schedule>()
                .HasOne(ps => ps.Participant)
                .WithMany(p => p.Participant_Schedules)
                .HasForeignKey(ps => ps.ParticipantId);
            modelBuilder.Entity<Participant_Schedule>()
                .HasOne(ps => ps.Schedule)
                .WithMany(s => s.Participant_Schedules)
                .HasForeignKey(ps => ps.ScheduleId);

            modelBuilder.Entity<TemporaryAnswers>()
                .HasKey(ta => new { ta.ScheduleId, ta.ParticipantId, ta.QuestionId });
            modelBuilder.Entity<TemporaryAnswers>()
                .HasOne(ta => ta.Participant_Schedule)
                .WithMany(ps => ps.TemporaryAnswers)
                .HasForeignKey(ps => new { ps.ParticipantId, ps.ScheduleId });
            modelBuilder.Entity<TemporaryAnswers>()
                .HasOne(ta => ta.Question)
                .WithMany(q => q.TemporaryAnswers)
                .HasForeignKey(ta => ta.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
