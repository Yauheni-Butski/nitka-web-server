namespace Domain.Context
{
    using Domain.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Images : BaseModel
    {
        [Required]
        public string ImageRelativePath { get; set; }

        [Required]
        public string ThumbRelativePath { get; set; }
    }
}
