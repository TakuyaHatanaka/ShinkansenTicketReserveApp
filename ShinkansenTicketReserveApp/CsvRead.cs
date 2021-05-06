using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp0408
{
    class CsvRead
    {
        #region フィールド
        private string _filename;

        #endregion

        #region コンストラクタ
        public CsvRead()
        {
            _filename = "";
        }
        #endregion

        #region プロパティ
        public string filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        #endregion

        #region メソッド
        public List<List<string>> ReadCsv(string filename)
        {
            StreamReader reader = null;
            List<List<string>> Lists = new List<List<string>>();
            //読込
            try
            {
                reader = new StreamReader(filename);
                int i = 0;
                while (!reader.EndOfStream)
                {
                    //初期化
                    string line = "";
                    //1行読み込む
                    line += reader.ReadLine();
                    //カンマで分割し配列に格納
                    string[] sline = line.Split(',');
                    if (sline[0] == "") break;
                    //配列をリストに格納
                    //行追加
                    Lists.Add(new List<string>());
                    //追加行に配列を格納
                    Lists[i].AddRange(sline);
                    //空白除去
                    Lists[i].RemoveAll(item => item == "");
                    i++;
                }
            }
            //エラー処理
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //閉じる
            finally
            {
                reader.Close();
            }
            //リストを返す
            return Lists;
        }
        #endregion
    }
}
