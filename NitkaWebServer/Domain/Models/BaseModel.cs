using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        /// <summary>
        /// Identity
        /// </summary>
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? Id { get; set; }
        /// <summary>
        /// Date and time of create
        /// </summary>
        [Column(Order = 2)]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreate { get; set; }
        /// <summary>
        /// Date and time of last update
        /// </summary>
        [Column(Order = 3)]
        public DateTime? LastUpdate { get; set; }

        public bool IsNew()
        {
            return this.Id == null;
        }

        protected void CopyTo(BaseModel target)
        {
            target.Id = Id;
            target.DateCreate = DateCreate;
            target.LastUpdate = LastUpdate;
        }
    }
}
