using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.Models
{
    public class Gig:BaseModel
    {
        public bool IsCanceled { get; private set; }

        public DateTime DateTime { get; set; }
       
        public string Venue { get; set; }
    }
}
