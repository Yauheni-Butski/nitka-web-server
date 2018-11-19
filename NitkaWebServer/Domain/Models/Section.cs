namespace Domain.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Section")]
    public partial class Section : BaseModel
    {
        public long? CategoryId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public int? Order { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public long? CoverImageId { get; set; }

        public virtual Category Category { get; set; }
    }
}
