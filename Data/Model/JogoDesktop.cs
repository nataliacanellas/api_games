using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class JogoDesktop : BaseModel
    {
        public string Name { get; set; }
        public string Theme { get; set; }
        public string SystemRequirements { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
