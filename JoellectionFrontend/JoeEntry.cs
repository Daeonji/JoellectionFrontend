using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoellectionFrontend
{
    public class JoeEntry
    {
        public string Name;
        public string Description;
        public string ImageLink;
        public string JoeID;

        public override string ToString()
        {
            return Name;
        }
    }
}
