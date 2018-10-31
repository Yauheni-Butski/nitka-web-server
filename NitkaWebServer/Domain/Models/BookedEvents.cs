namespace Domain.Context
{
    using Domain.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class BookedEvents : BaseModel
    {
        public int BookingStatusId { get; set; }

        [Required]
        [StringLength(128)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(128)]
        public string ClientEmail { get; set; }

        [StringLength(128)]
        public string ClientPhoneNumber { get; set; }

        public DateTime EventDate { get; set; }

        [Required]
        [StringLength(128)]
        public string EventPlace { get; set; }

        [Required]
        [StringLength(128)]
        public string EventType { get; set; }

        public TimeSpan EventStartTime { get; set; }

        public TimeSpan EventEndTime { get; set; }

        public string Notes { get; set; }

        public virtual BookingStatus BookingStatus { get; set; }
    }
}
