using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0408
{
    public partial class FormReserveDetail : Form
    {

        private string _date;
        private string _type;
        private string _fare;
        private string _departureStation;
        private string _arriveStation;
        private string _time;

        public string date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string fare
        {
            get { return _fare; }
            set { _fare = value; }
        }
        public string departureStation
        {
            get { return _departureStation; }
            set { _departureStation = value; }
        }
        public string arriveStation
        {
            get { return _arriveStation; }
            set { _arriveStation = value; }
        }
        public string time
        {
            get { return _time; }
            set { _time = value; }
        }



        public FormReserveDetail()
        {
            InitializeComponent();
        }

        private void FormReserveDetail_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.textBoxDate.Text = date;
            this.textBoxTrain.Text = type;
            this.textBoxFare.Text = fare;
            this.textBoxDeparture.Text = departureStation;
            this.textBoxArrive.Text = arriveStation;
            this.textBoxTime.Text = time;

        }
    }
}
