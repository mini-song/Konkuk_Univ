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
    public partial class precise_search : Form
    {
        private List<string> app_num;
        private List<string> app_date;
        private List<string> title;
        private List<string> abstract_;
        private List<string> inventors;
        private List<string> CPCs;
        private string search_word;
        public List<int> Num_save = new List<int>();
        public List<int> Num_save2 = new List<int>();
        public precise_search()
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
            sr.Close();
        }
        private void Btn_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                label_save2.Text = "";
                label_save.Text = "";
                listView_save2.Clear();
                listView_save.Items.Clear();
                Num_save.Clear();
                Num_save2.Clear();
                search_word = textBox_search.Text;
                List<string> target_List = new List<string>();
                List<string> save_inventors = new List<string>();
                List<int> save_inventors_num = new List<int>();
                List<int> save_inventors_num2 = new List<int>();
                List<string> save_title = new List<string>();
                if (radio_btn_inventors.Checked == true || radio_btn_title.Checked == true)
                {
                    if (radio_btn_inventors.Checked == true)
                    {
                        for (int i = 0; i < inventors.Count; i++)
                        {
                            if (inventors[i].IndexOf(";") != -1)
                            {
                                string[] ss = inventors[i].Split(';');
                                for (int ii = 0; ii < ss.Length; ii++)
                                {
                                    int save = ss[ii].IndexOf('(');
                                    string uu = "";
                                    for (int jj = 0; jj < save; jj++)
                                    {
                                        uu = uu + ss[ii][jj];
                                    }
                                    save_inventors.Add(uu);
                                    save_inventors_num.Add(i);
                                }
                            }
                            else if (inventors[i].IndexOf(";") == -1)
                            {
                                int save = inventors[i].IndexOf('(');
                                string uu = "";
                                for (int jj = 0; jj < save; jj++)
                                {
                                    uu = uu + inventors[i][jj];
                                }
                                save_inventors.Add(uu);
                                save_inventors_num.Add(i);
                            }
                        }
                        target_List = save_inventors;
                        for (int i = 0; i < target_List.Count; i++)
                        {
                            if (target_List[i] == search_word)
                            {
                                Num_save.Add(save_inventors_num[i]);
                                save_inventors_num2.Add(save_inventors_num[i]);
                            }
                            else if (target_List[i].IndexOf(search_word) != -1)
                            {
                                Num_save2.Add(i);
                            }
                        }
                    }
                    else if (radio_btn_title.Checked == true)
                    {
                        target_List = title;
                        for (int i = 0; i < target_List.Count(); i++)
                        {
                            if (target_List[i] == search_word)
                            {
                                Num_save.Add(i);
                            }
                        }
                        for (int i = 0; i < target_List.Count(); i++)
                        {
                            if (target_List[i].IndexOf(search_word) != -1)
                            {
                                Num_save2.Add(i);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    if (Num_save.Count != 0)
                    {
                        if (radio_btn_title.Checked == true)
                        {
                            foreach (int i in Num_save)
                            {
                                ListViewItem save = new ListViewItem(double.Parse(app_num[i]).ToString());
                                save.SubItems.Add(app_date[i]);
                                save.SubItems.Add(title[i]);
                                save.SubItems.Add(abstract_[i]);
                                save.SubItems.Add(inventors[i]);
                                save.SubItems.Add(CPCs[i]);
                                listView_save.Items.Add(save);
                            }
                        }
                        else if (radio_btn_inventors.Checked == true)
                        {
                            foreach (int i in save_inventors_num2)
                            {
                                ListViewItem save = new ListViewItem(double.Parse(app_num[i]).ToString());
                                save.SubItems.Add(app_date[i]);
                                save.SubItems.Add(title[i]);
                                save.SubItems.Add(abstract_[i]);
                                save.SubItems.Add(inventors[i]);
                                save.SubItems.Add(CPCs[i]);
                                listView_save.Items.Add(save);
                            }
                        }
                        label_save2.Text = "";
                        label_save.Text = "'" + search_word + "' 정밀 검색 " + listView_save.Items.Count.ToString() + "개의 검색 결과";
                    }
                    else if (Num_save.Count == 0)
                    {
                        if (Num_save2.Count != 0)
                        {
                            MessageBox.Show("검색어 '" + search_word + "' 완전히 일치 하는 검색어가 없습니다.\n다음 리스트는 '" + search_word + "' " +
                                "검색어를 포함하는 검색어 목록입니다.");
                            try
                            {
                                if (radio_btn_inventors.Checked == true)
                                {
                                    listView_save2.Columns.Add("발명가", 300);
                                    for (int i = 0; i < Num_save2.Count; i++)
                                    {
                                        ListViewItem save = new ListViewItem(target_List[Num_save2[i]]);
                                        listView_save2.Items.Add(save);
                                    }
                                }
                                else if (radio_btn_title.Checked == true)
                                {
                                    listView_save2.Columns.Add("특허명", 300);
                                    for (int i = 0; i < Num_save2.Count; i++)
                                    {
                                        if (save_title.IndexOf(title[Num_save2[i]]) == -1)
                                        {
                                            save_title.Add(title[Num_save2[i]]);
                                        }
                                    }
                                    foreach (string i in save_title)
                                    {
                                        ListViewItem save = new ListViewItem(i);
                                        listView_save2.Items.Add(save);
                                    }
                                }
                                label_save2.Text = "검색어 '" + search_word + "' " + listView_save2.Items.Count.ToString() + "개의 검색 결과입니다.";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        else if (Num_save2.Count == 0)
                        {
                            MessageBox.Show(" '"+search_word+"' 검색결과가 없습니다.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("항목을 체크해주세요");
                }
            }
            else
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
        }
        private void TextBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_Click(sender, e);
            }
        }
        private void ListView_save2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_plus_Click(sender, e);
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_save2.Items.Count != 0)
                {
                    listView_save.Items.Clear();
                    if (radio_btn_inventors.Checked == true)
                    {
                        string search_2 = listView_save2.SelectedItems[0].Text;
                        for (int i = 0; i < inventors.Count; i++)
                            if (inventors[i].IndexOf(search_2) != -1)
                            {
                                ListViewItem save = new ListViewItem(double.Parse(app_num[i]).ToString());
                                save.SubItems.Add(app_date[i]);
                                save.SubItems.Add(title[i]);
                                save.SubItems.Add(abstract_[i]);
                                save.SubItems.Add(inventors[i]);
                                save.SubItems.Add(CPCs[i]);
                                listView_save.Items.Add(save);
                            }

                    }
                    else if (radio_btn_title.Checked == true)
                    {
                        string search_2 = listView_save2.SelectedItems[0].Text;
                        for (int i = 0; i < title.Count; i++)
                            if (title[i].IndexOf(search_2) != -1)
                            {
                                ListViewItem save = new ListViewItem(double.Parse(app_num[i]).ToString());
                                save.SubItems.Add(app_date[i]);
                                save.SubItems.Add(title[i]);
                                save.SubItems.Add(abstract_[i]);
                                save.SubItems.Add(inventors[i]);
                                save.SubItems.Add(CPCs[i]);
                                listView_save.Items.Add(save);
                            }
                    }
                    else
                    {
                        MessageBox.Show("항목을 체크해주세요");
                    }
                    label_save.Text = "'" + listView_save2.SelectedItems[0].Text + "' 정밀 검색 " + listView_save.Items.Count.ToString() + 
                        "개의 검색 결과";
                    search_word = listView_save2.SelectedItems[0].Text;
                }
                else
                {
                    MessageBox.Show("리스트가 비어 있습니다.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("리스트 중 하나를 선택해주세요");
            }
        }
        private void Btn_carefully_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();


                if (listView_save.SelectedItems != null)
                {
                    string string_target = "등록신청번호 : " + listView_save.SelectedItems[0].Text + "\n" +
                    "출원 날짜 : " + listView_save.FocusedItem.SubItems[1].Text + "\n" +
                    "특허 이름 : " + listView_save.FocusedItem.SubItems[2].Text + "\n" +
                    "초록 : " + listView_save.FocusedItem.SubItems[3].Text + "\n" +
                    "발명인 : " + listView_save.FocusedItem.SubItems[4].Text + "\n" +
                    "CPCs : " + listView_save.FocusedItem.SubItems[5].Text + "\n";
                    int var_index = 0;
                    List<int> save_int = new List<int>();
                    for (int i = 0; i < string_target.Length; i++)
                    {
                        string_target.IndexOf(search_word, var_index);
                        if (save_int.Contains(string_target.IndexOf(search_word, var_index)) == false && 
                            string_target.IndexOf(search_word, var_index) != -1)
                        {
                            save_int.Add(string_target.IndexOf(search_word, var_index));
                        }
                        var_index = var_index + 1;
                    }
                    int target_length = search_word.Length;
                    richTextBox1.AppendText(string_target);

                    foreach (int uu in save_int)
                    {
                        richTextBox1.Select(uu, target_length);
                        richTextBox1.SelectionColor = Color.Blue;
                    }
                    richTextBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("자세히 보고 싶은 항목을 클릭해주세요");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("자세히 보고 싶은 항목을 클릭해주세요");
            }
        }
        private void ListView_save_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_carefully_Click(sender, e);
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Save(listView_save);
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

        private void Btn_save_all_Click(object sender, EventArgs e)
        {
            Save(listView_save2);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
