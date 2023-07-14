using lesson25.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25.ViewModel
{
    public class ViewUser
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? PhoneNumber { get; set; }

        public Gender Gender { get; set; } = Gender.Male;
    }
}
