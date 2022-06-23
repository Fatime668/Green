using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
    }
}
