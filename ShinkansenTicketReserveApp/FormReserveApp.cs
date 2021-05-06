using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp0408
{
    public partial class FormReserveApp : Form
    {
        #region 変数定義
        string bound = "";   //上り下り
        string type = "";    //列車タイプ
        string eType = "";   //列車タイプ(英語)
        /// <summary>
        /// 列車タイプ列挙
        /// </summary>
        enum TrainType
        {
            Nozomi,
            Hikari,
            Kodama,
        };
        enum RadioButtonName
        {
            radioNozomi,
            radioHiakri,
            radioKodama,
        };

        #endregion

        public FormReserveApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioNozomi.CheckedChanged += RadioButton_CheckedChanged;
            radioHikari.CheckedChanged += RadioButton_CheckedChanged;
            radioKodama.CheckedChanged += RadioButton_CheckedChanged;
        }

        #region メソッド
        /// <summary>
        /// ラジオボタンチェック時乗車駅リスト追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in groupBoxTrain.Controls)
            {
                if (radioButton.Checked) type = radioButton.Text;
            }
            ComboBoxInitialize();
            comboBoxDeparture.Items.AddRange(GetStationList(type));
        }

        /// <summary>
        /// 列車タイプ毎の駅名の配列を取得
        /// </summary>
        /// <param name="type">列車タイプ</param>
        string[] GetStationList(string type)
        {
            CsvReader station = new CsvReader();
            station.Lists = station.ReadCsv("csv/station.csv");

            int i = 0;      //行数
            int id = 1;     //インデックス
            //列車タイプで行を判定
            for (i = 0; i < station.Lists.Count; i++)
            {
                id = station.Lists[i].IndexOf(type);
                if (id == 0)
                {
                    break;
                }
            }
            //配列を宣言
            string[] stationList = new string[station.Lists[i].Count - 1];
            //リストを配列に変換
            stationList = station.Lists[i].ToArray();
            //コピー先の配列を作成する
            string[] stationListType = new string[station.Lists[i].Count - 1];
            //指定された範囲をコピーする
            Array.Copy(stationList, 1, stationListType, 0, station.Lists[i].Count - 1);
            //列車タイプ毎の駅リストを返す
            return stationListType;
        }

        /// <summary>
        /// combobox,datagridview初期化
        /// </summary>
        void ComboBoxInitialize()
        {
            comboBoxDeparture.Items.Clear();
            comboBoxArrive.Items.Clear();
            comboBoxDeparture.Text = null;
            comboBoxArrive.Text = null;
            dataGridViewTimeTable.Columns.Clear();
            comboBoxArrive.Enabled = false;
        }

        #endregion

        #region イベント

       

        /// <summary>
        /// 乗車駅で選択した駅名を降車駅から削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ラジオボタン配列化
            RadioButton[] radioButtons = { radioNozomi, radioHikari, radioKodama };
            //降車駅を入力可能に変更
            comboBoxArrive.Enabled = true;
            //降車駅クリア
            comboBoxArrive.Items.Clear();
            //降車駅追加
            foreach (int id in Enum.GetValues(typeof(RadioButtonName)))
            {
                if (radioButtons[id].Checked) comboBoxArrive.Items.AddRange(GetStationList(radioButtons[id].Text));
            }
            //選択乗車駅削除
            string stationDelete = comboBoxDeparture.Text;  //削除する駅名
            //駅名を削除
            comboBoxArrive.Items.Remove(stationDelete);
        }

        /// <summary>
        /// 時刻表検索ボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //駅リスト取得
            CsvReader station = new CsvReader();
            station.Lists = station.ReadCsv("csv/station.csv");

            //列車タイプ選択チェック
            if(!(radioNozomi.Checked || radioHikari.Checked || radioKodama.Checked))
            {
                MessageBox.Show("列車を選択してください");
                return;
            }

            if (!(comboBoxDeparture.SelectedItem != null && comboBoxArrive.SelectedItem != null))
            {
                MessageBox.Show("駅を選択してください");
                return;
            }

            string departureStation = comboBoxDeparture.Text;               //乗車駅
            string arriveStation = comboBoxArrive.Text;                     //降車駅
            string[] stationFilter = { departureStation, arriveStation };   //乗車駅と降車駅を配列化
            int i = 0;
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);

            //列車タイプ判定
            if (radioNozomi.Checked) eType = TrainType.Nozomi.ToString();
            if (radioHikari.Checked) eType = TrainType.Hikari.ToString();
            if (radioKodama.Checked) eType = TrainType.Kodama.ToString();

            //上り下り判定
            bool boundCheck = station.Lists[1].IndexOf(departureStation) < station.Lists[1].IndexOf(arriveStation);
            bound = boundCheck ? "InBound" : "OutBound";

            //時刻表読込
            //TimeTable = ReadCsv("TimeTable" + eType + bound + ".csv");
            CsvReader timeTable = new CsvReader();
            string filename = string.Format("csv/TimeTable/TimeTable{0}{1}.csv", eType, bound);
            timeTable.filename = filename;
            timeTable.Lists = timeTable.ReadCsv(timeTable.filename);

            //列(駅名)を追加
            for (i = 0; i < timeTable.Lists[0].Count; i++)
            {
                dt.Columns.Add(timeTable.Lists[0][i]);
            }
            //行(時間)を追加
            for(int j = 1; j < timeTable.Lists.Count; j++)
            {
                dt.Rows.Add(timeTable.Lists[j].ToArray());
            }
            //時刻表から乗降車駅でフィルタリングして表示
            dt = dv.ToTable(false, stationFilter);
            dataGridViewTimeTable.DataSource = dt;
        }

        /// <summary>
        /// 予約ボタン有効化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTimeTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonReserve.Enabled = true;
        }

        /// <summary>
        /// 予約ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReserve_Click(object sender, EventArgs e)
        {
            //料金(文字列)
            string sFare = "";
            //乗車日
            string date = dateTimePickerBoarding.Value.ToString("yyyy/MM/dd");
            //発車時刻と駅
            string departureTime = dataGridViewTimeTable.CurrentRow.Cells[0].Value.ToString();
            string departureStation = comboBoxDeparture.Text;
            //到着時刻と駅
            string arriveTime = dataGridViewTimeTable.CurrentRow.Cells[1].Value.ToString();
            string arriveStation = comboBoxArrive.Text;
            //列車タイプ
            if (radioNozomi.Checked) type = radioNozomi.Text;
            if (radioHikari.Checked) type = radioHikari.Text;
            if (radioKodama.Checked) type = radioKodama.Text;
            if (radioNozomi.Checked) eType = TrainType.Nozomi.ToString();
            if (radioHikari.Checked) eType = TrainType.Hikari.ToString();
            if (radioKodama.Checked) eType = TrainType.Kodama.ToString();

            //料金表取得
            //FareTable = ReadCsv("Fare" + eType + ".csv");
            CsvReader fareTable = new CsvReader();
            string filename = string.Format("csv/Fare/Fare{0}.csv", eType);
            fareTable.filename = filename;
            fareTable.Lists = fareTable.ReadCsv(fareTable.filename);
            //駅名からcellのインデックスを取得
            try
            {
                int colID = fareTable.Lists[0].IndexOf(departureStation);
                int rowID;
                for (rowID = 0; rowID < fareTable.Lists.Count; rowID++)
                {
                    if (arriveStation == fareTable.Lists[rowID][0]) break;
                }
                int iFare = int.Parse(fareTable.Lists[rowID][colID]);
                sFare = String.Format("{0:#,0}円", iFare);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //予約詳細をメッセージボックスに表示
            string message = string.Format("{0}駅{1}発\n{2}駅{3}着\n{4}号\n料金は{5}です。\n予約しますか？",
                                                departureStation, departureTime, arriveStation, arriveTime, type, sFare);
            DialogResult result = MessageBox.Show(message, "予約詳細", MessageBoxButtons.YesNo);

            //"はい"が選ばれたら予約完了
            if (result == DialogResult.Yes)
            {
                FormReserveDetail formDetail = new FormReserveDetail();
                //formDetail.textBoxDate.Text = date;
                //formDetail.textBoxTrain.Text = type;
                //formDetail.textBoxFare.Text = sFare;
                //formDetail.textBoxDeparture.Text = departureStation;
                //formDetail.textBoxArrive.Text = arriveStation;
                //formDetail.textBoxTime.Text = departureTime + "-" + arriveTime;

                formDetail.date = date;
                formDetail.type = type;
                formDetail.fare = sFare;
                formDetail.departureStation = departureStation;
                formDetail.arriveStation = arriveStation;
                formDetail.time = departureTime + "-" + arriveTime;

                formDetail.ShowDialog();

                string textfilename = "reserveDetail.txt";
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(textfilename, true, Encoding.UTF8);
                    writer.WriteLine("乗車日：" + date);
                    writer.WriteLine("出発：" + departureStation + "駅 " + departureTime + "発");
                    writer.WriteLine("到着：" + arriveStation + "駅 " + arriveTime + "着");
                    writer.WriteLine("列車：" + type);
                    writer.WriteLine("料金：" + sFare);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }
        }
        #endregion
    }
}
