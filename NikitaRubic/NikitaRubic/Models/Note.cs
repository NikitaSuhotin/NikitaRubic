using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikitaRubic.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
