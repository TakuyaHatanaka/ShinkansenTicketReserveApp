
namespace WindowsFormsApp0408
{
    partial class FormReserveApp
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserveApp));
            this.radioNozomi = new System.Windows.Forms.RadioButton();
            this.radioHikari = new System.Windows.Forms.RadioButton();
            this.radioKodama = new System.Windows.Forms.RadioButton();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.comboBoxArrive = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelArrive = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTrain = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelTimeTable = new System.Windows.Forms.Label();
            this.dataGridViewTimeTable = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerBoarding = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxTrain.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioNozomi
            // 
            this.radioNozomi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNozomi.AutoSize = true;
            this.radioNozomi.Location = new System.Drawing.Point(12, 37);
            this.radioNozomi.Name = "radioNozomi";
            this.radioNozomi.Size = new System.Drawing.Size(65, 19);
            this.radioNozomi.TabIndex = 2;
            this.radioNozomi.Text = "のぞみ";
            this.radioNozomi.UseVisualStyleBackColor = true;
            // 
            // radioHikari
            // 
            this.radioHikari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioHikari.AutoSize = true;
            this.radioHikari.Location = new System.Drawing.Point(83, 37);
            this.radioHikari.Name = "radioHikari";
            this.radioHikari.Size = new System.Drawing.Size(61, 19);
            this.radioHikari.TabIndex = 3;
            this.radioHikari.TabStop = true;
            this.radioHikari.Text = "ひかり";
            this.radioHikari.UseVisualStyleBackColor = true;
            // 
            // radioKodama
            // 
            this.radioKodama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioKodama.AutoSize = true;
            this.radioKodama.Location = new System.Drawing.Point(152, 37);
            this.radioKodama.Name = "radioKodama";
            this.radioKodama.Size = new System.Drawing.Size(61, 19);
            this.radioKodama.TabIndex = 4;
            this.radioKodama.TabStop = true;
            this.radioKodama.Text = "こだま";
            this.radioKodama.UseVisualStyleBackColor = true;
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(9, 36);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDeparture.TabIndex = 6;
            this.comboBoxDeparture.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeparture_SelectedIndexChanged);
            // 
            // comboBoxArrive
            // 
            this.comboBoxArrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArrive.Enabled = false;
            this.comboBoxArrive.FormattingEnabled = true;
            this.comboBoxArrive.Location = new System.Drawing.Point(9, 36);
            this.comboBoxArrive.Name = "comboBoxArrive";
            this.comboBoxArrive.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArrive.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 41);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Enabled = false;
            this.buttonReserve.Location = new System.Drawing.Point(9, 16);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(121, 41);
            this.buttonReserve.TabIndex = 10;
            this.buttonReserve.Text = "予約";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Location = new System.Drawing.Point(6, 9);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(52, 15);
            this.labelDeparture.TabIndex = 5;
            this.labelDeparture.Text = "乗車駅";
            // 
            // labelArrive
            // 
            this.labelArrive.AutoSize = true;
            this.labelArrive.Location = new System.Drawing.Point(6, 9);
            this.labelArrive.Name = "labelArrive";
            this.labelArrive.Size = new System.Drawing.Size(52, 15);
            this.labelArrive.TabIndex = 7;
            this.labelArrive.Text = "降車駅";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxTrain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 465);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // groupBoxTrain
            // 
            this.groupBoxTrain.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTrain.Controls.Add(this.radioHikari);
            this.groupBoxTrain.Controls.Add(this.radioKodama);
            this.groupBoxTrain.Controls.Add(this.radioNozomi);
            this.groupBoxTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTrain.Location = new System.Drawing.Point(3, 80);
            this.groupBoxTrain.Name = "groupBoxTrain";
            this.groupBoxTrain.Size = new System.Drawing.Size(226, 71);
            this.groupBoxTrain.TabIndex = 13;
            this.groupBoxTrain.TabStop = false;
            this.groupBoxTrain.Text = "列車";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelTimeTable);
            this.panel7.Controls.Add(this.dataGridViewTimeTable);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(235, 3);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel1.SetRowSpan(this.panel7, 6);
            this.panel7.Size = new System.Drawing.Size(343, 459);
            this.panel7.TabIndex = 14;
            // 
            // labelTimeTable
            // 
            this.labelTimeTable.AutoSize = true;
            this.labelTimeTable.Location = new System.Drawing.Point(15, 13);
            this.labelTimeTable.Name = "labelTimeTable";
            this.labelTimeTable.Size = new System.Drawing.Size(52, 15);
            this.labelTimeTable.TabIndex = 11;
            this.labelTimeTable.Text = "時刻表";
            // 
            // dataGridViewTimeTable
            // 
            this.dataGridViewTimeTable.AllowUserToAddRows = false;
            this.dataGridViewTimeTable.AllowUserToDeleteRows = false;
            this.dataGridViewTimeTable.AllowUserToResizeColumns = false;
            this.dataGridViewTimeTable.AllowUserToResizeRows = false;
            this.dataGridViewTimeTable.ColumnHeadersHeight = 29;
            this.dataGridViewTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTimeTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTimeTable.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewTimeTable.Name = "dataGridViewTimeTable";
            this.dataGridViewTimeTable.ReadOnly = true;
            this.dataGridViewTimeTable.RowHeadersWidth = 51;
            this.dataGridViewTimeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTimeTable.RowTemplate.Height = 24;
            this.dataGridViewTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTimeTable.Size = new System.Drawing.Size(337, 408);
            this.dataGridViewTimeTable.TabIndex = 12;
            this.dataGridViewTimeTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimeTable_RowEnter);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.buttonReserve);
            this.panel6.Location = new System.Drawing.Point(3, 388);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 74);
            this.panel6.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.buttonSearch);
            this.panel5.Location = new System.Drawing.Point(3, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 71);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.comboBoxArrive);
            this.panel4.Controls.Add(this.labelArrive);
            this.panel4.Location = new System.Drawing.Point(3, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 71);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.labelDeparture);
            this.panel3.Controls.Add(this.comboBoxDeparture);
            this.panel3.Location = new System.Drawing.Point(3, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 71);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.dateTimePickerBoarding);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 71);
            this.panel1.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 15);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "乗車日";
            // 
            // dateTimePickerBoarding
            // 
            this.dateTimePickerBoarding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBoarding.Location = new System.Drawing.Point(9, 36);
            this.dateTimePickerBoarding.Name = "dateTimePickerBoarding";
            this.dateTimePickerBoarding.Size = new System.Drawing.Size(214, 22);
            this.dateTimePickerBoarding.TabIndex = 1;
            // 
            // FormReserveApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReserveApp";
            this.Text = "FormReserveApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxTrain.ResumeLayout(false);
            this.groupBoxTrain.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioNozomi;
        private System.Windows.Forms.RadioButton radioHikari;
        private System.Windows.Forms.RadioButton radioKodama;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.ComboBox comboBoxArrive;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelArrive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBoarding;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelTimeTable;
        private System.Windows.Forms.DataGridView dataGridViewTimeTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxTrain;
    }
}

