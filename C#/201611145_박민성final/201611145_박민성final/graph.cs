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

namespace _201611145_박민성final
{
    public partial class graph : Form
    {
        public Dictionary<string, int> save_dic = new Dictionary<string, int>();
        public graph()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("./통계.csv", Encoding.Default, true);
            List<string> toggae = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                toggae.Add(data[0]);

            }
                List<int> value_savelist = new List<int>();
                List<string> key_savelist = new List<string>();
                for (int j = 0; j < toggae.Count(); j++)
                {
                    string b = toggae[j].ToString();
                    int c = 0;
                    for (int i = 0; i < toggae.Count(); i++)
                    {
                        if (b == toggae[i].ToString())
                        {
                            c++;
                        }
                    }
                    if (key_savelist.Contains(toggae[j]) == false)
                    {
                        value_savelist.Add(c);
                        key_savelist.Add(toggae[j]);
                    }
                }
                for (int ii = 0; ii < value_savelist.Count(); ii++)
                {
                    save_dic.Add(key_savelist[ii], value_savelist[ii]);
                }
                int int_count = 0;
                chart1.Series["인기 검색어 Top5"].Points.Clear();
                foreach (var item in save_dic.OrderByDescending(i => i.Value))
                {
                    chart1.Series["인기 검색어 Top5"].Points.AddXY(item.Key, item.Value);
                    int_count++;
                    if (int_count == 5)
                    { break; }
                }
            sr.Close();
        }
    }
}
