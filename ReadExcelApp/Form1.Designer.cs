namespace ReadExcelApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Template = new System.Windows.Forms.TabPage();
            this.DisplayTemplate = new System.Windows.Forms.DataGridView();
            this.tabPage_Results = new System.Windows.Forms.TabPage();
            this.DisplayResults = new System.Windows.Forms.DataGridView();
            this.tabPage_Difference = new System.Windows.Forms.TabPage();
            this.DisplayDifference = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox_TemplateSheet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TemplateSheet = new System.Windows.Forms.ComboBox();
            this.comboBox_TemplateColume = new System.Windows.Forms.ComboBox();
            this.groupBox_ResultSheet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_ResultSheet = new System.Windows.Forms.ComboBox();
            this.comboBox_ResultColume = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_TemplateFile = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Template = new System.Windows.Forms.TextBox();
            this.button_Template = new System.Windows.Forms.Button();
            this.groupBox_ResultFile = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTemplate)).BeginInit();
            this.tabPage_Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayResults)).BeginInit();
            this.tabPage_Difference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox_TemplateSheet.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox_ResultSheet.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_TemplateFile.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_ResultFile.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 941);
            this.splitContainer1.SplitterDistance = 772;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(1211, 772);
            this.splitContainer2.SplitterDistance = 647;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Template);
            this.tabControl1.Controls.Add(this.tabPage_Results);
            this.tabControl1.Controls.Add(this.tabPage_Difference);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1211, 647);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_Template
            // 
            this.tabPage_Template.Controls.Add(this.DisplayTemplate);
            this.tabPage_Template.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Template.Name = "tabPage_Template";
            this.tabPage_Template.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Template.Size = new System.Drawing.Size(1203, 615);
            this.tabPage_Template.TabIndex = 0;
            this.tabPage_Template.Text = "Template";
            this.tabPage_Template.UseVisualStyleBackColor = true;
            // 
            // DisplayTemplate
            // 
            this.DisplayTemplate.AllowUserToOrderColumns = true;
            this.DisplayTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayTemplate.Location = new System.Drawing.Point(3, 3);
            this.DisplayTemplate.Name = "DisplayTemplate";
            this.DisplayTemplate.RowHeadersWidth = 62;
            this.DisplayTemplate.RowTemplate.Height = 30;
            this.DisplayTemplate.Size = new System.Drawing.Size(1197, 609);
            this.DisplayTemplate.TabIndex = 1;
            // 
            // tabPage_Results
            // 
            this.tabPage_Results.Controls.Add(this.DisplayResults);
            this.tabPage_Results.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Results.Name = "tabPage_Results";
            this.tabPage_Results.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Results.Size = new System.Drawing.Size(1203, 616);
            this.tabPage_Results.TabIndex = 1;
            this.tabPage_Results.Text = "Results";
            this.tabPage_Results.UseVisualStyleBackColor = true;
            // 
            // DisplayResults
            // 
            this.DisplayResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayResults.Location = new System.Drawing.Point(3, 3);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.RowHeadersWidth = 62;
            this.DisplayResults.RowTemplate.Height = 30;
            this.DisplayResults.Size = new System.Drawing.Size(1197, 610);
            this.DisplayResults.TabIndex = 0;
            // 
            // tabPage_Difference
            // 
            this.tabPage_Difference.Controls.Add(this.DisplayDifference);
            this.tabPage_Difference.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Difference.Name = "tabPage_Difference";
            this.tabPage_Difference.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Difference.Size = new System.Drawing.Size(1203, 616);
            this.tabPage_Difference.TabIndex = 2;
            this.tabPage_Difference.Text = "Difference";
            this.tabPage_Difference.UseVisualStyleBackColor = true;
            // 
            // DisplayDifference
            // 
            this.DisplayDifference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDifference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayDifference.Location = new System.Drawing.Point(3, 3);
            this.DisplayDifference.Name = "DisplayDifference";
            this.DisplayDifference.RowHeadersWidth = 62;
            this.DisplayDifference.RowTemplate.Height = 30;
            this.DisplayDifference.Size = new System.Drawing.Size(1197, 610);
            this.DisplayDifference.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_TemplateSheet);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox_ResultSheet);
            this.splitContainer3.Size = new System.Drawing.Size(1211, 121);
            this.splitContainer3.SplitterDistance = 57;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox_TemplateSheet
            // 
            this.groupBox_TemplateSheet.Controls.Add(this.tableLayoutPanel4);
            this.groupBox_TemplateSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TemplateSheet.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TemplateSheet.Name = "groupBox_TemplateSheet";
            this.groupBox_TemplateSheet.Size = new System.Drawing.Size(1211, 57);
            this.groupBox_TemplateSheet.TabIndex = 0;
            this.groupBox_TemplateSheet.TabStop = false;
            this.groupBox_TemplateSheet.Text = "Template_Sheet";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.comboBox_TemplateSheet, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_TemplateColume, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1205, 30);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // comboBox_TemplateSheet
            // 
            this.comboBox_TemplateSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_TemplateSheet.FormattingEnabled = true;
            this.comboBox_TemplateSheet.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TemplateSheet.Name = "comboBox_TemplateSheet";
            this.comboBox_TemplateSheet.Size = new System.Drawing.Size(897, 26);
            this.comboBox_TemplateSheet.TabIndex = 0;
            this.comboBox_TemplateSheet.SelectedIndexChanged += new System.EventHandler(this.comboBox_TemplateSheet_SelectedIndexChanged);
            // 
            // comboBox_TemplateColume
            // 
            this.comboBox_TemplateColume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_TemplateColume.FormattingEnabled = true;
            this.comboBox_TemplateColume.Location = new System.Drawing.Point(906, 3);
            this.comboBox_TemplateColume.Name = "comboBox_TemplateColume";
            this.comboBox_TemplateColume.Size = new System.Drawing.Size(296, 26);
            this.comboBox_TemplateColume.TabIndex = 1;
            this.comboBox_TemplateColume.SelectedIndexChanged += new System.EventHandler(this.comboBox_TemplateColume_SelectedIndexChanged);
            // 
            // groupBox_ResultSheet
            // 
            this.groupBox_ResultSheet.Controls.Add(this.tableLayoutPanel5);
            this.groupBox_ResultSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ResultSheet.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ResultSheet.Name = "groupBox_ResultSheet";
            this.groupBox_ResultSheet.Size = new System.Drawing.Size(1211, 60);
            this.groupBox_ResultSheet.TabIndex = 1;
            this.groupBox_ResultSheet.TabStop = false;
            this.groupBox_ResultSheet.Text = "Result_Sheet";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox_ResultSheet, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBox_ResultColume, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1205, 33);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // comboBox_ResultSheet
            // 
            this.comboBox_ResultSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_ResultSheet.FormattingEnabled = true;
            this.comboBox_ResultSheet.Location = new System.Drawing.Point(3, 3);
            this.comboBox_ResultSheet.Name = "comboBox_ResultSheet";
            this.comboBox_ResultSheet.Size = new System.Drawing.Size(897, 26);
            this.comboBox_ResultSheet.TabIndex = 0;
            this.comboBox_ResultSheet.SelectedIndexChanged += new System.EventHandler(this.comboBox_ResultSheet_SelectedIndexChanged);
            // 
            // comboBox_ResultColume
            // 
            this.comboBox_ResultColume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_ResultColume.FormattingEnabled = true;
            this.comboBox_ResultColume.Location = new System.Drawing.Point(906, 3);
            this.comboBox_ResultColume.Name = "comboBox_ResultColume";
            this.comboBox_ResultColume.Size = new System.Drawing.Size(296, 26);
            this.comboBox_ResultColume.TabIndex = 1;
            this.comboBox_ResultColume.SelectedIndexChanged += new System.EventHandler(this.comboBox_ResultColume_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_TemplateFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_ResultFile, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_TemplateFile
            // 
            this.groupBox_TemplateFile.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_TemplateFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TemplateFile.Location = new System.Drawing.Point(3, 3);
            this.groupBox_TemplateFile.Name = "groupBox_TemplateFile";
            this.groupBox_TemplateFile.Size = new System.Drawing.Size(1205, 76);
            this.groupBox_TemplateFile.TabIndex = 0;
            this.groupBox_TemplateFile.TabStop = false;
            this.groupBox_TemplateFile.Text = "Template File";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_Template, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Template, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1199, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox_Template
            // 
            this.textBox_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Template.Location = new System.Drawing.Point(3, 3);
            this.textBox_Template.Multiline = true;
            this.textBox_Template.Name = "textBox_Template";
            this.textBox_Template.Size = new System.Drawing.Size(993, 43);
            this.textBox_Template.TabIndex = 0;
            this.textBox_Template.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Template
            // 
            this.button_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Template.Location = new System.Drawing.Point(1002, 3);
            this.button_Template.Name = "button_Template";
            this.button_Template.Size = new System.Drawing.Size(194, 43);
            this.button_Template.TabIndex = 1;
            this.button_Template.Text = "TemplateFile";
            this.button_Template.UseVisualStyleBackColor = true;
            this.button_Template.Click += new System.EventHandler(this.button_Template_Click);
            // 
            // groupBox_ResultFile
            // 
            this.groupBox_ResultFile.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_ResultFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ResultFile.Location = new System.Drawing.Point(3, 85);
            this.groupBox_ResultFile.Name = "groupBox_ResultFile";
            this.groupBox_ResultFile.Size = new System.Drawing.Size(1205, 77);
            this.groupBox_ResultFile.TabIndex = 1;
            this.groupBox_ResultFile.TabStop = false;
            this.groupBox_ResultFile.Text = "Results File";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_Results, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Result, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1199, 50);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_Results
            // 
            this.textBox_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Results.Location = new System.Drawing.Point(3, 3);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.Size = new System.Drawing.Size(993, 44);
            this.textBox_Results.TabIndex = 0;
            this.textBox_Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Result
            // 
            this.button_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Result.Location = new System.Drawing.Point(1002, 3);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(194, 44);
            this.button_Result.TabIndex = 1;
            this.button_Result.Text = "ResultsFile";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button_Start);
            this.splitContainer4.Size = new System.Drawing.Size(1211, 985);
            this.splitContainer4.SplitterDistance = 941;
            this.splitContainer4.TabIndex = 1;
            // 
            // button_Start
            // 
            this.button_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Start.FlatAppearance.BorderSize = 2;
            this.button_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_Start.Location = new System.Drawing.Point(0, 0);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(1211, 40);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1211, 985);
            this.Controls.Add(this.splitContainer4);
            this.MinimumSize = new System.Drawing.Size(22, 1000);
            this.Name = "MainForm";
            this.Text = "ReadExcelApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Template.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTemplate)).EndInit();
            this.tabPage_Results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayResults)).EndInit();
            this.tabPage_Difference.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDifference)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox_TemplateSheet.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox_ResultSheet.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_TemplateFile.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_ResultFile.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_ResultFile;
        private System.Windows.Forms.GroupBox groupBox_TemplateFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_Template;
        private System.Windows.Forms.Button button_Template;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox_TemplateSheet;
        private System.Windows.Forms.GroupBox groupBox_ResultSheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox_TemplateSheet;
        private System.Windows.Forms.ComboBox comboBox_TemplateColume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox comboBox_ResultSheet;
        private System.Windows.Forms.ComboBox comboBox_ResultColume;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Template;
        private System.Windows.Forms.DataGridView DisplayTemplate;
        private System.Windows.Forms.TabPage tabPage_Results;
        private System.Windows.Forms.DataGridView DisplayResults;
        private System.Windows.Forms.TabPage tabPage_Difference;
        private System.Windows.Forms.DataGridView DisplayDifference;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button button_Start;
    }
}

