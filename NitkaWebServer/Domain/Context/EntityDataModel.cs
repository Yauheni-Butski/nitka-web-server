namespace Domain.Context
{
    using System.Data.Entity;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataModel")
        {
        }

        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<BookedEvents> BookedEvents { get; set; }
        public virtual DbSet<BookingStatus> BookingStatus { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ContactQuestions> ContactQuestions { get; set; }
        public virtual DbSet<FrequentlyAskedQuestions> FrequentlyAskedQuestions { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<ImagesCategory> ImagesCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingStatus>()
                .HasMany(e => e.BookedEvents)
                .WithRequired(e => e.BookingStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
