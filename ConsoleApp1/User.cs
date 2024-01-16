using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User : BaseEntity
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

    }
}
