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
    public partial class quick_search : Form
    {
        private List<string> app_num;
        private List<string> app_date;
        private List<string> title;
        private List<string> abstract_;
        private List<string> inventors;
        private List<string> CPCs;
        private string search_word;
        public List<int> Num_save = new List<int>();
        public string Search_word
        {
            set
            {
                this.search_word = value;
            }
            get
            {
                return search_word;
            }
        }
        public quick_search()
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
        private void Btn_add_Click(object sender, EventArgs e)
        {
            listView_search.Columns.Clear();
            listView_search.Items.Clear();
            listView_save.Columns.Clear();
            listView_save.Items.Clear();
            Num_save.Clear();
            for (int i = 0; i < inventors.Count(); i++)
            {
                if (inventors[i].IndexOf(Search_word) != -1 || title[i].IndexOf(Search_word) != -1
                    || app_date[i].IndexOf(Search_word) != -1 || abstract_[i].IndexOf(Search_word) != -1 || CPCs[i].IndexOf(Search_word) != -1
                    || app_num[i].IndexOf(Search_word) != -1)
                {
                    Num_save.Add(i);
                }
                else
                    continue;
            }
            if (Num_save.Count == 0)
            {
                MessageBox.Show("' " + Search_word + " ' 를 포함하는 검색어가 존재하지 않습니다.\n초기화면으로 돌아갑니다.");
                this.Close();
            }
            else if (Num_save.Count != 0)
            {
                foreach (string i in checkedListBox_header.CheckedItems)
                {
                    listView_search.Columns.Add(i);
                    listView_save.Columns.Add(i);
                }
                if (checkedListBox_header.CheckedItems.Count != 0)
                {
                    string string_result = "'" + Search_word + "' 검색결과 ";
                    for (int x = 0; x < checkedListBox_header.CheckedItems.Count; x++)
                    {
                        string_result = string_result + checkedListBox_header.CheckedItems[x].ToString() + ", ";
                    }
                    string_result = string_result + "위의 항목들만 나타낸 자료 입니다.";
                    label_result.Text = string_result;
                    label_search_count.Text = "검색 결과 : " + Num_save.Count().ToString() + "건";
                }
                if (checkedListBox_header.CheckedItems.Contains("등록신청번호"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem((double.Parse(app_num[i])).ToString());
                        if ((checkedListBox_header.CheckedItems.Contains("출원일")))
                        {
                            search.SubItems.Add(app_date[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("특허명")))
                        {
                            search.SubItems.Add(title[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("초록")))
                        {
                            search.SubItems.Add(abstract_[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("발명가")))
                        {
                            search.SubItems.Add(inventors[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("CPCs")))
                        {
                            search.SubItems.Add(CPCs[i]);
                        }
                        listView_search.Items.Add(search);
                    }
                }
                else if (checkedListBox_header.CheckedItems.Contains("출원일"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem(app_date[i]);
                        if ((checkedListBox_header.CheckedItems.Contains("특허명")))
                        {
                            search.SubItems.Add(title[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("초록")))
                        {
                            search.SubItems.Add(abstract_[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("발명가")))
                        {
                            search.SubItems.Add(inventors[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("CPCs")))
                        {
                            search.SubItems.Add(CPCs[i]);
                        }
                        listView_search.Items.Add(search);
                    }
                }
                else if (checkedListBox_header.CheckedItems.Contains("특허명"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem(title[i]);
                        if ((checkedListBox_header.CheckedItems.Contains("초록")))
                        {
                            search.SubItems.Add(abstract_[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("발명가")))
                        {
                            search.SubItems.Add(inventors[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("CPCs")))
                        {
                            search.SubItems.Add(CPCs[i]);
                        }
                        listView_search.Items.Add(search);
                    }
                }
                else if (checkedListBox_header.CheckedItems.Contains("초록"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem(abstract_[i]);
                        if ((checkedListBox_header.CheckedItems.Contains("발명가")))
                        {
                            search.SubItems.Add(inventors[i]);
                        }
                        if ((checkedListBox_header.CheckedItems.Contains("CPCs")))
                        {
                            search.SubItems.Add(CPCs[i]);
                        }
                        listView_search.Items.Add(search);
                    }
                }
                else if (checkedListBox_header.CheckedItems.Contains("발명가"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem(inventors[i]);
                        if ((checkedListBox_header.CheckedItems.Contains("CPCs")))
                        {
                            search.SubItems.Add(CPCs[i]);
                        }

                        listView_search.Items.Add(search);
                    }
                }
                else if (checkedListBox_header.CheckedItems.Contains("CPCs"))
                {
                    foreach (int i in Num_save)
                    {
                        ListViewItem search = new ListViewItem(CPCs[i]);
                        listView_search.Items.Add(search);
                    }
                }
                else
                {
                    MessageBox.Show("보고 싶은 항목을 체크해주세요");
                }
                for (int i = 0; i < listView_search.Columns.Count; i++)
                {
                    listView_search.Columns[i].Width = 87;
                    listView_save.Columns[i].Width = 87;
                    listView_save.Columns[i].TextAlign = HorizontalAlignment.Center;
                    listView_search.Columns[i].TextAlign = HorizontalAlignment.Center;

                }
            }
            if (checkedListBox_header.CheckedItems.Count != 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("./통계.csv", true, System.Text.Encoding.GetEncoding("ks_c_5601-1987")))
                {
                    file.WriteLine("{0}", Search_word);
                    file.Close();
                }
            }
        }
        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            if (listView_search.FocusedItem == null)
            {
                MessageBox.Show("추가 할 항목을 클릭해 주세요");
            }
            else
            {
                try
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
                catch (Exception)
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
        private void ListView_search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_plus_Click(sender, e);
        }
        private void ListView_save_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Btn_minus_Click(sender, e);
        }
        private void Btn_spool_Click(object sender, EventArgs e)
        {
            Save(listView_save);
        }
        private void Btn_all_save_Click(object sender, EventArgs e)
        {
            Save(listView_search);
        }
        private void Btn_tonggae_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./통계.csv", Encoding.Default, true);
            List<string> toggae = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split(',');
                toggae.Add(data[0]);
            }
            if (toggae.Count == 0)
            {
                MessageBox.Show("자료가 없습니다.");
            }
            else
            {
                graph toggae_garph = new graph();
                toggae_garph.Show();
            }
            sr.Close();
        }
        private void Btn_carefully_Click(object sender, EventArgs e)
        {
            try
            {
                int k = 0;
                richTextBox1.Clear();
                if (listView_save.SelectedItems != null && listView_search.SelectedItems != null)
                {
                    if (listView_search.SelectedItems != null)

                    {
                        k = Num_save[listView_search.SelectedIndices[0]];
                    }
                    else if (listView_save.SelectedItems != null)
                    {
                        k = Num_save[listView_save.SelectedIndices[0]];
                    }
                    string string_target = "등록신청번호 : " + double.Parse(app_num[k]).ToString() + "\n" +
                    "출원 날짜 : " + app_date[k] + "\n" +
                    "특허명 : " + title[k] + "\n" +
                    "초록 : " + abstract_[k] + "\n" +
                    "발명인 : " + inventors[k] + "\n" +
                    "CPCs : " + CPCs[k] + "\n";
                    int var_index = 0;
                    List<int> save_int = new List<int>();
                    for (int i = 0; i < string_target.Length; i++)
                    {
                        string_target.IndexOf(Search_word, var_index);
                        if (save_int.Contains(string_target.IndexOf(Search_word, var_index)) == false &&
                            string_target.IndexOf(Search_word, var_index) != -1)
                        {
                            save_int.Add(string_target.IndexOf(Search_word, var_index));
                        }
                        var_index = var_index + 1;
                    }
                    int target_length = Search_word.Length;
                    richTextBox1.AppendText(string_target);

                    foreach (int uu in save_int)
                    {
                        richTextBox1.Select(uu, target_length);
                        richTextBox1.SelectionColor = Color.Blue;
                    }
                    richTextBox1.Visible = true;
                    btn_close.Visible = true;
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("자세히 보고 싶은 항목을\n체크해주세요");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("항목을 먼저 체크해주세요");
            }

        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void Btn_born_Click_1(object sender, EventArgs e)
        {
            string file = "./";
            string[] txtList = Directory.GetFiles(file, "./통계.csv");

            foreach (string f in txtList)
            {
                File.Delete(f);
            }
            MessageBox.Show("통계 수치가 초기화 되었습니다.");
            using (System.IO.StreamWriter file2 = new System.IO.StreamWriter("./통계.csv", true,
                System.Text.Encoding.GetEncoding("ks_c_5601-1987"))) ;
        }

    }
}
