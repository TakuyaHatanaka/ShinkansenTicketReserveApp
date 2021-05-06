
namespace WindowsFormsApp0408
{
    partial class FormReserveDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserveDetail));
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.textBoxArrive = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDepartureStation = new System.Windows.Forms.Label();
            this.labelArriveStation = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFare = new System.Windows.Forms.Label();
            this.labelTrain = new System.Windows.Forms.Label();
            this.textBoxFare = new System.Windows.Forms.TextBox();
            this.textBoxTrain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDate.Location = new System.Drawing.Point(100, 44);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(100, 15);
            this.textBoxDate.TabIndex = 2;
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDeparture.Location = new System.Drawing.Point(100, 115);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.ReadOnly = true;
            this.textBoxDeparture.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeparture.TabIndex = 8;
            // 
            // textBoxArrive
            // 
            this.textBoxArrive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxArrive.Location = new System.Drawing.Point(100, 194);
            this.textBoxArrive.Name = "textBoxArrive";
            this.textBoxArrive.ReadOnly = true;
            this.textBoxArrive.Size = new System.Drawing.Size(100, 22);
            this.textBoxArrive.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.Location = new System.Drawing.Point(134, 158);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(100, 15);
            this.textBoxTime.TabIndex = 9;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 43);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "乗車日";
            // 
            // labelDepartureStation
            // 
            this.labelDepartureStation.AutoSize = true;
            this.labelDepartureStation.Location = new System.Drawing.Point(24, 118);
            this.labelDepartureStation.Name = "labelDepartureStation";
            this.labelDepartureStation.Size = new System.Drawing.Size(52, 15);
            this.labelDepartureStation.TabIndex = 7;
            this.labelDepartureStation.Text = "乗車駅";
            // 
            // labelArriveStation
            // 
            this.labelArriveStation.AutoSize = true;
            this.labelArriveStation.Location = new System.Drawing.Point(24, 197);
            this.labelArriveStation.Name = "labelArriveStation";
            this.labelArriveStation.Size = new System.Drawing.Size(52, 15);
            this.labelArriveStation.TabIndex = 10;
            this.labelArriveStation.Text = "降車駅";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(70, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "予約詳細";
            // 
            // labelFare
            // 
            this.labelFare.AutoSize = true;
            this.labelFare.Location = new System.Drawing.Point(24, 86);
            this.labelFare.Name = "labelFare";
            this.labelFare.Size = new System.Drawing.Size(37, 15);
            this.labelFare.TabIndex = 5;
            this.labelFare.Text = "料金";
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Location = new System.Drawing.Point(24, 65);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(37, 15);
            this.labelTrain.TabIndex = 3;
            this.labelTrain.Text = "列車";
            // 
            // textBoxFare
            // 
            this.textBoxFare.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxFare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFare.Location = new System.Drawing.Point(100, 86);
            this.textBoxFare.Name = "textBoxFare";
            this.textBoxFare.ReadOnly = true;
            this.textBoxFare.Size = new System.Drawing.Size(100, 15);
            this.textBoxFare.TabIndex = 6;
            // 
            // textBoxTrain
            // 
            this.textBoxTrain.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTrain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTrain.Location = new System.Drawing.Point(100, 65);
            this.textBoxTrain.Name = "textBoxTrain";
            this.textBoxTrain.ReadOnly = true;
            this.textBoxTrain.Size = new System.Drawing.Size(100, 15);
            this.textBoxTrain.TabIndex = 4;
            // 
            // FormReserveDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 237);
            this.Controls.Add(this.textBoxTrain);
            this.Controls.Add(this.textBoxFare);
            this.Controls.Add(this.labelTrain);
            this.Controls.Add(this.labelFare);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelArriveStation);
            this.Controls.Add(this.labelDepartureStation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxArrive);
            this.Controls.Add(this.textBoxDeparture);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReserveDetail";
            this.Text = "FormReserveDetail";
            this.Load += new System.EventHandler(this.FormReserveDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxDate;
        public System.Windows.Forms.TextBox textBoxDeparture;
        public System.Windows.Forms.TextBox textBoxArrive;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDepartureStation;
        private System.Windows.Forms.Label labelArriveStation;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFare;
        private System.Windows.Forms.Label labelTrain;
        public System.Windows.Forms.TextBox textBoxFare;
        public System.Windows.Forms.TextBox textBoxTrain;
    }
}