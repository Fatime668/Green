using Green.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green.ViewModels
{
    public class HomeVM
    {
        public Setting Setting { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
