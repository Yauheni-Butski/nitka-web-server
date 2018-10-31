namespace Domain.Context
{
    using Domain.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BookingStatus : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookingStatus()
        {
            BookedEvents = new HashSet<BookedEvents>();
        }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookedEvents> BookedEvents { get; set; }
    }
}
