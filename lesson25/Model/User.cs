using lesson25.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? PhoneNumber { get; set; }

        public Gender Gender { get; set; } = Gender.Male;


    }
}
