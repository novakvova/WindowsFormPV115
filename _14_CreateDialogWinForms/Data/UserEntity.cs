using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateDialogWinForms.Data
{
    public enum Gender
    {
        Male=0,
        Female=1,
    }
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
