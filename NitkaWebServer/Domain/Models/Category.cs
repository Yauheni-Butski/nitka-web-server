namespace Domain.Context
{
    using Domain.Models;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public partial class Category : BaseModel
    {
        public long? ParentId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public int? Order { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public long? CoverImageId { get; set; }
    }
}
