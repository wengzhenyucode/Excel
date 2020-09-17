using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadExcelApp
{
    public class ControlResult
    {

        public string DetectTime { get; set; }

        public string concentration { get; set; }

        public double concentration_num { get; set; }

        public string concentration_level { get; set; }

        public string reagent_item { get; set; }
            
        public string count_value { get; set; }

        public int count_value_num { get; set; }

        public ControlResult()
        { 
        
        
        }

    }
}
