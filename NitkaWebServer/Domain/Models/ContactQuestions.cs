namespace Domain.Context
{
    using Domain.Models;
    using System.ComponentModel.DataAnnotations;

    public partial class ContactQuestions : BaseModel
    {
        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
