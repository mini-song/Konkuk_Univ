namespace _201611145_박민성final
{
    partial class quick_search
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
            this.listView_search = new System.Windows.Forms.ListView();
            this.btn_add = new System.Windows.Forms.Button();
            this.checkedListBox_header = new System.Windows.Forms.CheckedListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_all_save = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_spool = new System.Windows.Forms.Button();
            this.btn_tonggae = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_carefully = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_born = new System.Windows.Forms.Button();
            this.listView_save = new System.Windows.Forms.ListView();
            this.label_result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_search_count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_search
            // 
            this.listView_search.FullRowSelect = true;
            this.listView_search.GridLines = true;
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(45, 206);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(627, 494);
            this.listView_search.TabIndex = 22;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_search_MouseDoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(161, 126);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 26);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "선택";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // checkedListBox_header
            // 
            this.checkedListBox_header.FormattingEnabled = true;
            this.checkedListBox_header.Items.AddRange(new object[] {
            "등록신청번호",
            "출원일",
            "특허명",
            "초록",
            "발명가",
            "CPCs"});
            this.checkedListBox_header.Location = new System.Drawing.Point(87, 28);
            this.checkedListBox_header.Name = "checkedListBox_header";
            this.checkedListBox_header.Size = new System.Drawing.Size(136, 124);
            this.checkedListBox_header.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1255, 716);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(204, 23);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "초기화면으로 돌아가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_all_save
            // 
            this.btn_all_save.Location = new System.Drawing.Point(57, 716);
            this.btn_all_save.Name = "btn_all_save";
            this.btn_all_save.Size = new System.Drawing.Size(130, 23);
            this.btn_all_save.TabIndex = 26;
            this.btn_all_save.Text = "모두 저장";
            this.btn_all_save.UseVisualStyleBackColor = true;
            this.btn_all_save.Click += new System.EventHandler(this.Btn_all_save_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(715, 393);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 28;
            this.btn_plus.Text = "추가";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(715, 476);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 29;
            this.btn_minus.Text = "삭제";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Btn_minus_Click);
            // 
            // btn_spool
            // 
            this.btn_spool.Location = new System.Drawing.Point(970, 716);
            this.btn_spool.Name = "btn_spool";
            this.btn_spool.Size = new System.Drawing.Size(172, 23);
            this.btn_spool.TabIndex = 30;
            this.btn_spool.Text = "장바구니 저장";
            this.btn_spool.UseVisualStyleBackColor = true;
            this.btn_spool.Click += new System.EventHandler(this.Btn_spool_Click);
            // 
            // btn_tonggae
            // 
            this.btn_tonggae.Location = new System.Drawing.Point(1237, 115);
            this.btn_tonggae.Name = "btn_tonggae";
            this.btn_tonggae.Size = new System.Drawing.Size(192, 37);
            this.btn_tonggae.TabIndex = 31;
            this.btn_tonggae.Text = "통계 자료 보기";
            this.btn_tonggae.UseVisualStyleBackColor = true;
            this.btn_tonggae.Click += new System.EventHandler(this.Btn_tonggae_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(80, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(668, 523);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btn_carefully
            // 
            this.btn_carefully.Location = new System.Drawing.Point(388, 716);
            this.btn_carefully.Name = "btn_carefully";
            this.btn_carefully.Size = new System.Drawing.Size(177, 23);
            this.btn_carefully.TabIndex = 36;
            this.btn_carefully.Text = "자세히 보기";
            this.btn_carefully.UseVisualStyleBackColor = true;
            this.btn_carefully.Click += new System.EventHandler(this.Btn_carefully_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(636, 562);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 35);
            this.btn_close.TabIndex = 39;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_born
            // 
            this.btn_born.Location = new System.Drawing.Point(1349, 3);
            this.btn_born.Name = "btn_born";
            this.btn_born.Size = new System.Drawing.Size(151, 26);
            this.btn_born.TabIndex = 42;
            this.btn_born.Text = "통계초기화";
            this.btn_born.UseVisualStyleBackColor = true;
            this.btn_born.Click += new System.EventHandler(this.Btn_born_Click_1);
            // 
            // listView_save
            // 
            this.listView_save.FullRowSelect = true;
            this.listView_save.GridLines = true;
            this.listView_save.HideSelection = false;
            this.listView_save.Location = new System.Drawing.Point(848, 206);
            this.listView_save.Name = "listView_save";
            this.listView_save.Size = new System.Drawing.Size(611, 504);
            this.listView_save.TabIndex = 27;
            this.listView_save.UseCompatibleStateImageBehavior = false;
            this.listView_save.View = System.Windows.Forms.View.Details;
            this.listView_save.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_save_MouseDoubleClick);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(84, 164);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(227, 15);
            this.label_result.TabIndex = 43;
            this.label_result.Text = "↑ 원하시는 항목을 클릭해주세요";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(346, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 615);
            this.panel1.TabIndex = 44;
            this.panel1.Visible = false;
            // 
            // label_search_count
            // 
            this.label_search_count.AutoSize = true;
            this.label_search_count.Location = new System.Drawing.Point(84, 179);
            this.label_search_count.Name = "label_search_count";
            this.label_search_count.Size = new System.Drawing.Size(72, 15);
            this.label_search_count.TabIndex = 45;
            this.label_search_count.Text = "빠른 검색";
            // 
            // quick_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1512, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_search_count);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listView_save);
            this.Controls.Add(this.btn_born);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.checkedListBox_header);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.btn_carefully);
            this.Controls.Add(this.btn_tonggae);
            this.Controls.Add(this.btn_spool);
            this.Controls.Add(this.btn_all_save);
            this.Controls.Add(this.btn_back);
            this.Name = "quick_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "빠른 검색";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckedListBox checkedListBox_header;
        private System.Windows.Forms.Button btn_back;

        private System.Windows.Forms.Button btn_all_save;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_spool;
        private System.Windows.Forms.Button btn_tonggae;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_carefully;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_born;
        private System.Windows.Forms.ListView listView_save;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_search_count;
    }
}