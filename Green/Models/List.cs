using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
