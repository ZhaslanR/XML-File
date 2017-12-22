using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_lesson
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Mark { get; set; }
        public int Rating { get; set; }
        public DateTime MadeDate { get; set; }
    }
}
