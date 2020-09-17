using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Threading;

namespace ReadExcelApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //DataGridView标题、内容居中显示
            DisplayTemplate.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayTemplate.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayResults.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayResults.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayDifference.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayDifference.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }



        private DataTableCollection tableCollection;//sheet集合

        private DataTableCollection resultTableCollection; // Result sheet集合

        
        private DataColumnCollection columnCollection; //column集合

        private DataColumnCollection resultColumnCollection;//Result column集合

        private DataTable templateDT;//template DataTable

        private DataTable resultDT;// results DataTable

        private string serialNumer;  //设备编号
        private void button_Template_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel文件|*.xls;*.xlsx;*.csv", Title = "请选择Excel文件", Multiselect = false })
                {
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFile.FileName;

                        string fileName = Path.GetFileNameWithoutExtension(filePath);

                        Regex r = new Regex(@"[a-zA-Z]+");//英文正则表达式

                        Match m = r.Match(fileName);

                        serialNumer = '#'+ fileName.Substring(0, fileName.IndexOf(m.Value));
            
                       
                        using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                        {

                            textBox_Template.Text = filePath;

                            using (IExcelDataReader reader = filePath.Contains(".csv")? ExcelReaderFactory.CreateCsvReader(stream): ExcelReaderFactory.CreateReader(stream))  
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {

                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                                });

                                tableCollection = result.Tables;

                                comboBox_TemplateSheet.Items.Clear();

                                foreach (DataTable table in tableCollection)
                                {
                                    comboBox_TemplateSheet.Items.Add(table.TableName);
                                }

                            }

                        }

                    }

                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
          
        }

     


        private void comboBox_TemplateSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                templateDT = tableCollection[comboBox_TemplateSheet.SelectedItem.ToString()];

                //dataDisplay.DataSource = dt;

                columnCollection = templateDT.Columns;

                //显示
                DisplayTemplate.DataSource = templateDT;

                foreach (DataColumn dataColumn in columnCollection)
                {

                    comboBox_TemplateColume.Items.Add(dataColumn.ColumnName);

                    DisplayTemplate.Columns[dataColumn.ColumnName].Visible = true;

                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
          
          

        }

        
        private void comboBox_TemplateColume_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataColumn dataColumn = columnCollection[comboBox_TemplateColume.SelectedItem.ToString()];


                //只显示选中列
                foreach (DataColumn column in columnCollection)
                {

                    if (column.ColumnName.Equals(dataColumn.ColumnName))
                    {
                        DisplayTemplate.Columns[column.ColumnName].Visible = true;
                    }
                    else
                    {
                        DisplayTemplate.Columns[column.ColumnName].Visible = false;
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
                
            }

        }

        //数据处理函数
        public void DataProcess(DataTable templateDT,DataTable resultsDT)
        {
            try
            {
                if (templateDT == null)
                {
                    throw new Exception("templateDT not Exsit");
                }

                List<ControlResult> CRlist = new List<ControlResult>();

                foreach (DataRow row in templateDT.Rows)
                {
                    ControlResult result = new ControlResult();

                    if (templateDT.Columns.Contains("多重检测") && !Convert.IsDBNull(row["多重检测"]))
                    {
                        result.DetectTime = Convert.ToString(row["多重检测"]);
                    }

                    if (templateDT.Columns.Contains("浓度") && !Convert.IsDBNull(row["浓度"]))
                    {
                        string concentrationString = Convert.ToString(row["浓度"]);

                        double concentrationDouble = StringTODouble(concentrationString);

                        result.concentration = concentrationString;

                        result.concentration_num = concentrationDouble;

                        if (concentrationDouble >= 80 && concentrationDouble <= 120)
                        {
                            result.concentration_level = "H";
                        }
                        else if (concentrationDouble > 8 && concentrationDouble < 20)
                        {
                            result.concentration_level = "M";
                        }
                        else
                        {
                            result.concentration_level = "L";
                        }

                    }

                    if (templateDT.Columns.Contains("读数") && !Convert.IsDBNull(row["读数"]))
                    {
                        result.count_value = Convert.ToString(row["读数"]);


                        result.count_value_num = Convert.ToInt32(row["读数"]);


                    }
                    if (templateDT.Columns.Contains("分析项目") && !Convert.IsDBNull(row["分析项目"]))
                    {
                        result.reagent_item = Convert.ToString(row["分析项目"]);
                    }

                    CRlist.Add(result);

                }



                var query = from s in CRlist.Where(c => c.concentration_num != 0.1 && c.reagent_item == "AFP")
                            group new { s.concentration_num, s.count_value_num } by new { s.concentration_level, s.reagent_item } into m
                            select new
                            {
                                reagent_item = m.Key.reagent_item, //测试项目
                                concentration_level = m.Key.concentration_level,//浓度水平
                                concentration_avg = m.Average(x => x.concentration_num),//浓度平均值
                                count_value_avg = m.Average(x => x.count_value_num),//发光值平均值
                                count = m.Count(),//数量

                            };

                var mergeQuery = from q in CRlist
                                 join m in query on new { q.reagent_item, q.concentration_level } equals new { m.reagent_item, m.concentration_level }
                                 select new
                                 {
                                     reagent_item = q.reagent_item,//测试项目
                                     concentration = q.concentration_num, //浓度值
                                     concentration_level = q.concentration_level,//浓度水平
                                     concentration_avg = m.concentration_avg,//浓度平均值
                                     count_value_avg = m.count_value_avg,//发光值平均值
                                     count = m.count,//数量
                                     d_value = q.concentration_num - m.concentration_avg,//浓度-浓度平均值
                                     c_value = q.count_value_num - m.count_value_avg//发光值-发光值平均值

                                 };



                var sumQuery = from m in mergeQuery
                               group new { m.d_value, m.c_value } by new { m.reagent_item, m.concentration_level, m.count, m.concentration_avg, m.count_value_avg } into m
                               select new
                               {
                                   reagent_item = m.Key.reagent_item,//测试项目
                                   concentration_level = m.Key.concentration_level,//浓度水平
                                   count = m.Key.count,//数量
                                   concentration_avg = m.Key.concentration_avg,//浓度平均值
                                   count_value_avg = m.Key.count_value_avg,//发光值平均值
                                   concentration_sd = Math.Sqrt(m.Sum(x => (x.d_value) * (x.d_value)) / m.Key.count),//浓度值标准差
                                   count_value_sd = Math.Sqrt(m.Sum(x => (x.c_value) * (x.c_value)) / m.Key.count),//发光值标准差
                                   concentration_cv = Math.Sqrt(m.Sum(x => (x.d_value) * (x.d_value)) / m.Key.count) / m.Key.concentration_avg,//浓度值Cv
                                   count_value_cv = Math.Sqrt(m.Sum(x => (x.c_value) * (x.c_value)) / m.Key.count) / m.Key.count_value_avg,//发光值Cv

                               };


                var combineQuery = from a in sumQuery.Where(x => x.concentration_level == "H")
                                   join b in sumQuery.Where(x => x.concentration_level == "M") on a.reagent_item equals b.reagent_item
                                   join c in sumQuery.Where(x => x.concentration_level == "L") on a.reagent_item equals c.reagent_item
                                   select new
                                   {
                                       reagent_item = a.reagent_item,//测试项目

                                       //高浓度值
                                       concentration_avg_H = a.concentration_avg,//高浓度平均值
                                       concentration_sd_H = a.concentration_sd,//高浓度标准差
                                       concentration_cv_H = a.concentration_cv,//高浓度Cv

                                       //高浓度发光值
                                       count_value_avg_H = a.count_value_avg,//高浓度发光值平均值
                                       count_value_sd_H = a.count_value_sd,//高浓度发光值标准差
                                       count_value_cv_H = a.count_value_cv,//高浓度发光值Cv

                                       //中浓度值
                                       concentration_avg_M = b.concentration_avg,//中浓度平均值
                                       concentration_sd_M = b.concentration_sd,//中浓度标准差
                                       concentration_cv_M = b.concentration_cv,//中浓度Cv

                                       //中浓度发光值
                                       count_value_avg_M = b.count_value_avg,//中浓度发光值平均值
                                       count_value_sd_M = b.count_value_sd,//中浓度发光值标准差
                                       count_value_cv_M = b.count_value_cv,//中浓度发光值Cv

                                       //低浓度值
                                       concentration_avg_L = c.concentration_avg,//低浓度平均值
                                       concentration_sd_L = c.concentration_sd,//低浓度标准差
                                       concentration_cv_L = c.concentration_cv,//低浓度Cv

                                       //低浓度发光值
                                       count_value_avg_L = c.count_value_avg,//低浓度发光值平均值
                                       count_value_sd_L = c.count_value_sd,//低浓度发光值标准差
                                       count_value_cv_L = c.count_value_cv,//低浓度发光值Cv

                                   };


                //绑定字符串
                BindingList<Precision> PrecisionList = new BindingList<Precision>();

                foreach (var item in combineQuery)
                {
                    Precision precision = new Precision();

                    precision.serial_number = serialNumer;//设备编号

                    precision.reagent_item = item.reagent_item;//测试项目


                    //高浓度
                    precision.concentrationAvg_H = String.Format("{0:F}", item.concentration_avg_H);//高浓度均值

                    precision.concentrationCv_H = String.Format("{0:P2}", item.concentration_cv_H);//高浓度Cv

                    precision.countValueAvg_H = String.Format("{0:F}", item.count_value_avg_H);//高浓度发光均值

                    precision.countValueCv_H = String.Format("{0:P2}", item.count_value_cv_H);//高浓度发光值Cv

                    //中浓度
                    precision.concentrationAvg_M = String.Format("{0:F}", item.concentration_avg_M);//中浓度均值

                    precision.concentrationCv_M = String.Format("{0:P2}", item.concentration_cv_M);//中浓度Cv

                    precision.countValueAvg_M = String.Format("{0:F}", item.count_value_avg_M);//中浓度发光均值

                    precision.countValueCv_M = String.Format("{0:P2}", item.count_value_cv_M);//中浓度发光值Cv

                    //低浓度
                    precision.concentrationAvg_L = String.Format("{0:F}", item.concentration_avg_L); //低浓度均值

                    precision.concentrationCv_L = String.Format("{0:P2}", item.concentration_cv_L);//低浓度Cv

                    precision.countValueAvg_L = String.Format("{0:F}", item.count_value_avg_L);//低浓度发光均值

                    precision.countValueCv_L = String.Format("{0:P2}", item.count_value_cv_L);//低浓度发光值Cv


                    PrecisionList.Add(precision);


                }


                DisplayDifference.DataSource = PrecisionList;




            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
           


        }


        public Double StringTODouble(string concertration)
        {

            Double stringtodouble=0.0;
            try
            {
                if (concertration.StartsWith(">") || concertration.StartsWith("<"))
                {

                    concertration=concertration.Substring(1);
                }

                if (concertration.EndsWith("IU/mL"))
                {

                    concertration=concertration.Substring(0, concertration.Length - 5);
                }

                stringtodouble = Convert.ToDouble(concertration);
   
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }

            return stringtodouble;

        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openResultFile = new OpenFileDialog() { Filter = "Excel文件|*.xls;*.xlsx;*.csv", Title = "请选择Excel文件", Multiselect = false })
                {
                    if (openResultFile.ShowDialog() == DialogResult.OK)
                    {
                        string resultFilePath = openResultFile.FileName;

                      
                        using (var stream = File.Open(openResultFile.FileName, FileMode.Open, FileAccess.Read))
                        {
                            textBox_Results.Text = resultFilePath;
                            using (IExcelDataReader reader = resultFilePath.Contains(".csv") ? ExcelReaderFactory.CreateCsvReader(stream) : ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {

                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                                });

                                resultTableCollection = result.Tables;

                                comboBox_ResultSheet.Items.Clear();

                                foreach (DataTable table in resultTableCollection)
                                {
                                    comboBox_ResultSheet.Items.Add(table.TableName);
                                }

                            }

                        }

                    }               
                
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox_ResultSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                resultDT = resultTableCollection[comboBox_ResultSheet.SelectedItem.ToString()];

                DisplayResults.DataSource = resultDT;

                resultColumnCollection = resultDT.Columns;

                foreach (DataColumn dataColumn in resultColumnCollection)
                {

                    comboBox_ResultColume.Items.Add(dataColumn.ColumnName);

                    DisplayResults.Columns[dataColumn.ColumnName].Visible = true;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void comboBox_ResultColume_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataColumn dataColumn = resultColumnCollection[comboBox_ResultColume.SelectedItem.ToString()];


                //只显示选中列
                foreach (DataColumn column in resultColumnCollection)
                {

                    if (column.ColumnName.Equals(dataColumn.ColumnName))
                    {
                        DisplayResults.Columns[column.ColumnName].Visible = true;
                    }
                    else
                    {
                        DisplayResults.Columns[column.ColumnName].Visible = false;
                    }

                }

            }
            catch(Exception ex) 
            {

                MessageBox.Show(ex.Message);
             
            }
            
         
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

            DataProcess(templateDT, resultDT);

        }
    }
}
