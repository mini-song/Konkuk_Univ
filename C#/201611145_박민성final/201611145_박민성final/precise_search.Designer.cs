namespace _201611145_박민성final
{
    partial class precise_search
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.radio_btn_inventors = new System.Windows.Forms.RadioButton();
            this.radio_btn_title = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.listView_save = new System.Windows.Forms.ListView();
            this.등록신청번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.출원일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.특허명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.초록 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.발명가 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cps_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_save2 = new System.Windows.Forms.ListView();
            this.label_save2 = new System.Windows.Forms.Label();
            this.label_save = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_carefully = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_save_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(22, 57);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(231, 25);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_search_KeyDown);
            // 
            // radio_btn_inventors
            // 
            this.radio_btn_inventors.AutoSize = true;
            this.radio_btn_inventors.Location = new System.Drawing.Point(111, 25);
            this.radio_btn_inventors.Name = "radio_btn_inventors";
            this.radio_btn_inventors.Size = new System.Drawing.Size(73, 19);
            this.radio_btn_inventors.TabIndex = 1;
            this.radio_btn_inventors.TabStop = true;
            this.radio_btn_inventors.Text = "발명가";
            this.radio_btn_inventors.UseVisualStyleBackColor = true;
            // 
            // radio_btn_title
            // 
            this.radio_btn_title.AutoSize = true;
            this.radio_btn_title.Location = new System.Drawing.Point(22, 25);
            this.radio_btn_title.Name = "radio_btn_title";
            this.radio_btn_title.Size = new System.Drawing.Size(73, 19);
            this.radio_btn_title.TabIndex = 2;
            this.radio_btn_title.TabStop = true;
            this.radio_btn_title.Text = "특허명";
            this.radio_btn_title.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(270, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 26);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // listView_save
            // 
            this.listView_save.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.등록신청번호,
            this.출원일,
            this.특허명,
            this.초록,
            this.발명가,
            this.cps_});
            this.listView_save.FullRowSelect = true;
            this.listView_save.GridLines = true;
            this.listView_save.HideSelection = false;
            this.listView_save.Location = new System.Drawing.Point(450, 129);
            this.listView_save.Name = "listView_save";
            this.listView_save.Size = new System.Drawing.Size(596, 218);
            this.listView_save.TabIndex = 8;
            this.listView_save.UseCompatibleStateImageBehavior = false;
            this.listView_save.View = System.Windows.Forms.View.Details;
            this.listView_save.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_save_MouseDoubleClick);
            // 
            // 등록신청번호
            // 
            this.등록신청번호.Text = "등록신청번호";
            this.등록신청번호.Width = 116;
            // 
            // 출원일
            // 
            this.출원일.Text = "출원일";
            this.출원일.Width = 72;
            // 
            // 특허명
            // 
            this.특허명.Text = "특허명";
            this.특허명.Width = 90;
            // 
            // 초록
            // 
            this.초록.Text = "초록";
            this.초록.Width = 72;
            // 
            // 발명가
            // 
            this.발명가.Text = "발명가";
            this.발명가.Width = 84;
            // 
            // cps_
            // 
            this.cps_.Text = "CPCs";
            this.cps_.Width = 87;
            // 
            // listView_save2
            // 
            this.listView_save2.FullRowSelect = true;
            this.listView_save2.GridLines = true;
            this.listView_save2.HideSelection = false;
            this.listView_save2.Location = new System.Drawing.Point(22, 117);
            this.listView_save2.Name = "listView_save2";
            this.listView_save2.Size = new System.Drawing.Size(299, 483);
            this.listView_save2.TabIndex = 9;
            this.listView_save2.UseCompatibleStateImageBehavior = false;
            this.listView_save2.View = System.Windows.Forms.View.Details;
            this.listView_save2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_save2_MouseDoubleClick);
            // 
            // label_save2
            // 
            this.label_save2.AutoSize = true;
            this.label_save2.Location = new System.Drawing.Point(19, 99);
            this.label_save2.Name = "label_save2";
            this.label_save2.Size = new System.Drawing.Size(177, 15);
            this.label_save2.TabIndex = 10;
            this.label_save2.Text = "↑ 검색어를 입력해주세요";
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.Location = new System.Drawing.Point(447, 99);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(107, 15);
            this.label_save.TabIndex = 11;
            this.label_save.Text = "정밀 검색 결과";
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(337, 219);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(101, 24);
            this.btn_plus.TabIndex = 12;
            this.btn_plus.Text = "자세히 보기";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
            // 
            // btn_carefully
            // 
            this.btn_carefully.Location = new System.Drawing.Point(932, 353);
            this.btn_carefully.Name = "btn_carefully";
            this.btn_carefully.Size = new System.Drawing.Size(114, 23);
            this.btn_carefully.TabIndex = 13;
            this.btn_carefully.Text = "크게 보기";
            this.btn_carefully.UseVisualStyleBackColor = true;
            this.btn_carefully.Click += new System.EventHandler(this.Btn_carefully_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(450, 353);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 259);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(992, 661);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(851, 352);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_save_all
            // 
            this.btn_save_all.Location = new System.Drawing.Point(22, 606);
            this.btn_save_all.Name = "btn_save_all";
            this.btn_save_all.Size = new System.Drawing.Size(75, 23);
            this.btn_save_all.TabIndex = 17;
            this.btn_save_all.Text = "저장";
            this.btn_save_all.UseVisualStyleBackColor = true;
            this.btn_save_all.Click += new System.EventHandler(this.Btn_save_all_Click);
            // 
            // precise_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1080, 687);
            this.Controls.Add(this.btn_save_all);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_carefully);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.label_save);
            this.Controls.Add(this.label_save2);
            this.Controls.Add(this.listView_save2);
            this.Controls.Add(this.listView_save);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.radio_btn_title);
            this.Controls.Add(this.radio_btn_inventors);
            this.Controls.Add(this.btn_search);
            this.Name = "precise_search";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정밀 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.RadioButton radio_btn_inventors;
        private System.Windows.Forms.RadioButton radio_btn_title;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView listView_save;
        private System.Windows.Forms.ColumnHeader 등록신청번호;
        private System.Windows.Forms.ColumnHeader 출원일;
        private System.Windows.Forms.ColumnHeader 특허명;
        private System.Windows.Forms.ColumnHeader 초록;
        private System.Windows.Forms.ColumnHeader 발명가;
        private System.Windows.Forms.ColumnHeader cps_;
        private System.Windows.Forms.ListView listView_save2;
        private System.Windows.Forms.Label label_save2;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_carefully;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_save_all;
    }
}