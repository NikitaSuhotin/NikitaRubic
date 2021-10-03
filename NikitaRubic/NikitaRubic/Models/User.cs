using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace NikitaRubic.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthsday { get; set; }
    }
}
