using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Loaction { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterLogo { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
