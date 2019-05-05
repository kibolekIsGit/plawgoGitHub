using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        //public bool IsActive { get; set; } = true;

        public string CreatedUser { get; set; }

        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
