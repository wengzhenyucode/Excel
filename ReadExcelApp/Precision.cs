using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadExcelApp
{
    public class Precision
    {
        [DisplayName("设备编号")]
       
        public string serial_number { get; set; }
        [DisplayName("测试项目")]
        public string reagent_item { get; set; }
        [DisplayName("高浓度均值")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public string concentrationAvg_H { get; set; }
        //[DisplayName("高浓度标准差")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
       // public string concentrationSd_H { get; set; }
        [DisplayName("高浓度Cv")]
        //[DisplayFormat(DataFormatString = "{0:P}")]
        public string concentrationCv_H { get; set; }

        [DisplayName("高浓度发光均值")]
        public string countValueAvg_H { get; set; }

        [DisplayName("高浓度发光值Cv")]
        public string countValueCv_H { get; set; }

        [DisplayName("中浓度均值")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public string concentrationAvg_M { get; set; }
       // [DisplayName("中浓度标准差")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
       // public string concentrationSd_M { get; set; }
        [DisplayName("中浓度Cv")]
        //[DisplayFormat(DataFormatString = "{0:P}")]
        public string concentrationCv_M { get; set; }

        [DisplayName("中浓度发光均值")]
        public string countValueAvg_M { get; set; }

        [DisplayName("中浓度发光值Cv")]
        public string countValueCv_M { get; set; }

        [DisplayName("低浓度均值")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public string concentrationAvg_L { get; set; }
        //[DisplayName("低浓度标准差")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
       // public string concentrationSd_L { get; set; }
        [DisplayName("低浓度Cv")]
        //[DisplayFormat(DataFormatString ="{0:F}")]
        public string concentrationCv_L { get; set; }

        [DisplayName("低浓度发光均值")]
        public string countValueAvg_L { get; set; }

        [DisplayName("低浓度发光值Cv")]
        public string countValueCv_L { get; set; }


        public Precision()
        { 
        
        
        }

    }
}
