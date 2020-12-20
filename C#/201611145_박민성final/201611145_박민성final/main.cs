using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201611145_박민성final
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            pictureBox_category_search.Load("./카테고리검색.png");
            pictureBox_category_search.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_quick_search.Load("./빠른검색.png");
            pictureBox_quick_search.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_precise_search.Load("./정밀검색.png");
            pictureBox_precise_search.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox_konkuk.Load("./konkuk.jpg");
            pictureBox_konkuk.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_quicksearch_Click(object sender, EventArgs e)
        {
            if (textBox_quicksearch.Text != "")
            {
                quick_search Quick_search = new quick_search();
                Quick_search.Search_word = textBox_quicksearch.Text;
                Quick_search.ShowDialog();
            }
            else
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
        }
        private void TextBox_quicksearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_quicksearch_Click(sender, e);
            }
        }
        private void PictureBox_category_search_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_category_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void PictureBox_category_search_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_category_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void PictureBox_precise_search_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_precise_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void PictureBox_precise_search_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_precise_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void PictureBox_category_search_MouseClick(object sender, MouseEventArgs e)
        {
            category_search Category_search = new category_search();
            Category_search.Show();
        }
        private void PictureBox_precise_search_MouseClick(object sender, MouseEventArgs e)
        {
            precise_search Precise_search = new precise_search();
            Precise_search.Show();
        }

    }
}
