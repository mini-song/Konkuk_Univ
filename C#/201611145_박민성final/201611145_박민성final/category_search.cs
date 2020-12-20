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
    public partial class category_search : Form
    {
        private List<string> app_num;
        private List<string> app_date;
        private List<string> title;
        private List<string> abstract_;
        private List<string> inventors;
        private List<string> CPCs;
        public category_search()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("./개인과제data.csv", Encoding.Default, true);
            List<string> app_num = new List<string>();
            this.app_num = app_num;
            List<string> app_date = new List<string>();
            this.app_date = app_date;
            List<string> title = new List<string>();
            this.title = title;
            List<string> abstract_ = new List<string>();
            this.abstract_ = abstract_;
            List<string> inventors = new List<string>();
            this.inventors = inventors;
            List<string> CPCs = new List<string>();
            this.CPCs = CPCs;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                app_num.Add(data[0]);
                app_date.Add(data[1]);
                title.Add(data[2]);
                abstract_.Add(data[3]);
                inventors.Add(data[4]);
                CPCs.Add(data[5]);
            }
        }
        private void Btn_category_Click(object sender, EventArgs e)
        {
            listView_search.Items.Clear();
            if (textBox_app_num.Text.Length + textBox_app_date.Text.Length + textBox_title.Text.Length +
                textBox_inventors.Text.Length + textBox_abstract.Text.Length + textBox_CPCs.Text.Length == 0)
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                try
                {
                    List<int> Num_save = new List<int>();
                    if (textBox_app_num.Text.Length == 0)
                    {
                        for (int i = 0; i < inventors.Count(); i++)
                        {
                            if (inventors[i].IndexOf(textBox_inventors.Text) != -1 && title[i].IndexOf(textBox_title.Text) != -1
                                && app_date[i].IndexOf(textBox_app_date.Text) != -1 && abstract_[i].IndexOf(textBox_abstract.Text) != -1 &&
                                CPCs[i].IndexOf(textBox_CPCs.Text) != -1
                                && app_num[i].IndexOf(textBox_app_num.Text) != -1)
                            {
                                Num_save.Add(i);
                            }
                            else
                                continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < inventors.Count(); i++)
                        {
                            if (inventors[i].IndexOf(textBox_inventors.Text) != -1 && title[i].IndexOf(textBox_title.Text) != -1
                                && app_date[i].IndexOf(textBox_app_date.Text) != -1 && abstract_[i].IndexOf(textBox_abstract.Text) != -1
                                && CPCs[i].IndexOf(textBox_CPCs.Text) != -1
                                && app_num[i].IndexOf(double.Parse(textBox_app_num.Text).ToString()) != -1)
                            {
                                Num_save.Add(i);
                            }
                            else
                                continue;
                        }
                    }
                    foreach (int i in Num_save)
                    {
                        ListViewItem save = new ListViewItem(double.Parse(app_num[i]).ToString());

                        save.SubItems.Add(app_date[i]);
                        save.SubItems.Add(title[i]);
                        save.SubItems.Add(abstract_[i]);
                        save.SubItems.Add(inventors[i]);
                        save.SubItems.Add(CPCs[i]);
                        listView_search.Items.Add(save);
                    }
                    string string_explain = ("다음은 [");
                    if (textBox_app_num.Text.Length != 0)
                    {
                        string_explain = string_explain + "등록신청번호 : "+textBox_app_num.Text +" , ";
                    }
                    if (textBox_app_date.Text.Length != 0)
                    {
                        string_explain = string_explain + "출원일 : " + textBox_app_date.Text + " , ";
                    }
                    if (textBox_title.Text.Length != 0)
                    {
                        string_explain = string_explain + "특허명 : " + textBox_title.Text + " , ";
                    }
                    if (textBox_abstract.Text.Length != 0)
                    {
                        string_explain = string_explain + "초록 : " + textBox_abstract.Text + " , ";
                    }
                    if (textBox_inventors.Text.Length != 0)
                    {
                        string_explain = string_explain + "발명가 : " + textBox_inventors.Text + " , ";
                    }
                    if (textBox_CPCs.Text.Length != 0)
                    {
                        string_explain = string_explain + "CPCs : " + textBox_CPCs.Text;
                    }
                    string_explain = string_explain+ "] 가 포함된 검색 결과입니다.";
                    label_explain.Text = string_explain+ "\n검색 결과 : " + Num_save.Count().ToString() + " 건";
                 }
                catch (Exception)
                {
                        MessageBox.Show("등록신청 번호에는 숫자만 입력해주세요");
                }
            }
        }
        private void Save(ListView save)
        {
            if (save.Items.Count == 0)
            {
                MessageBox.Show("저장할 검색 기록이 없습니다.");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "csv File|*.csv";
                saveFileDialog1.Title = "Save";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            string pprint = "";
                            for (int j = 0; j < save.Columns.Count; j++)
                            {
                                pprint = pprint + save.Columns[j].Text + ", ";
                            }
                            pprint = pprint + "\n";
                            Byte[] bBytes = Encoding.Default.GetBytes(pprint);
                            fs.Write(bBytes, 0, bBytes.Length);
                            for (int i = 0; i < save.Items.Count; i++)
                            {
                                string sTmp = "";
                                for (int j = 0; j < save.Items[i].SubItems.Count; j++)
                                    sTmp += save.Items[i].SubItems[j].Text + ", ";
                                sTmp += "\n";
                                Byte[] Bytes = Encoding.Default.GetBytes(sTmp);
                                fs.Write(Bytes, 0, Bytes.Length);
                            }
                            break;
                    }
                    fs.Close();
                }
            }
        }
        private void Btn_search_save_Click(object sender, EventArgs e)
        {
            Save(listView_search);
        }
        private void Btn_save_save_Click(object sender, EventArgs e)
        {
            Save(listView_save);
        }
       
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            if (listView_search.FocusedItem == null)
            {
                MessageBox.Show("추가 할 항목을 클릭해 주세요");
            }
            else
            {
                int a = 0;
                for (int i = 0; i < listView_save.Items.Count; i++)
                {
                    if (listView_save.Items[i].SubItems[0].Text == listView_search.SelectedItems[0].SubItems[0].Text &&
                        listView_save.Items[i].SubItems[1].Text == listView_search.SelectedItems[0].SubItems[1].Text &&
                        listView_save.Items[i].SubItems[2].Text == listView_search.SelectedItems[0].SubItems[2].Text &&
                        listView_save.Items[i].SubItems[3].Text == listView_search.SelectedItems[0].SubItems[3].Text &&
                        listView_save.Items[i].SubItems[4].Text == listView_search.SelectedItems[0].SubItems[4].Text &&
                        listView_save.Items[i].SubItems[5].Text == listView_search.SelectedItems[0].SubItems[5].Text)
                    {
                        a = a + 1;

                    }
                }
                if (a == 0)
                {
                    ListViewItem save = new ListViewItem(listView_search.FocusedItem.SubItems[0].Text);
                    for (int i = 1; i < listView_search.Columns.Count; i++)
                    {
                        save.SubItems.Add(listView_search.FocusedItem.SubItems[i].Text);
                    }

                    listView_save.Items.Add(save);
                    listView_search.FocusedItem.Focused = false;
                }
                else
                {
                    MessageBox.Show("이미 장바구니에 있는 항목입니다.");
                }
            }
        }
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            if (listView_save.FocusedItem == null)
            {
                MessageBox.Show("삭제할목록을 체크해주세요.");
            }
            else if (listView_save.FocusedItem != null)
            {
                listView_save.FocusedItem.Remove();
                if (listView_save.Items.Count != 0)
                {
                    listView_save.FocusedItem.Focused = false;
                }
            }
        }
        private void ListView_search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_plus_Click(sender, e);
        }
        private void ListView_save_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_minus_Click(sender, e);
        }
        private void TextBox_app_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void TextBox_app_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void TextBox_title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void TextBox_abstract_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void TextBox_inventors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void TextBox_CPCs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_category_Click(sender, e);
            }
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
