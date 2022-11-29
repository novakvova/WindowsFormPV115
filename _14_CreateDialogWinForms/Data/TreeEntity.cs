using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateDialogWinForms.Data
{
    [Table("tblTreeEntities")]
    public class TreeEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Image { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public virtual TreeEntity Parent { get; set; }
    }
}
