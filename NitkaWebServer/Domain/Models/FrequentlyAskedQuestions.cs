namespace Domain.Context
{
    using Domain.Models;
    using System.ComponentModel.DataAnnotations;

    public partial class FrequentlyAskedQuestions : BaseModel
    {
        [Required]
        [StringLength(500)]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }
    }
}
