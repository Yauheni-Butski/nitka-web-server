namespace Domain.Context
{
    using Domain.Models;
    using System.ComponentModel.DataAnnotations;

    public partial class AdminUsers : BaseModel
    {
        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(128)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }
    }
}
