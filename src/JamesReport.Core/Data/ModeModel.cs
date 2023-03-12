using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesReport.Data
{
    public class ModeModel
    {
        public string Display { get; set; }
        public string Value { get; set; }

        public ModeModel(string display, string value)
        {
            Display = display;
            Value = value;
        }
    }
}
