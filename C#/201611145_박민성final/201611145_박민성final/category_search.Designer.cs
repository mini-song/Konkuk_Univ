namespace _201611145_박민성final
{
    partial class category_search
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
            this.btn_category = new System.Windows.Forms.Button();
            this.textBox_app_num = new System.Windows.Forms.TextBox();
            this.textBox_app_date = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_abstract = new System.Windows.Forms.TextBox();
            this.textBox_inventors = new System.Windows.Forms.TextBox();
            this.textBox_CPCs = new System.Windows.Forms.TextBox();
            this.listView_search = new System.Windows.Forms.ListView();
            this.등록신청번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.출원일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.특허명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.초록 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.발명가 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cps_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_등록신청번호 = new System.Windows.Forms.Label();
            this.label_출원일 = new System.Windows.Forms.Label();
            this.label_특허명 = new System.Windows.Forms.Label();
            this.label_초록 = new System.Windows.Forms.Label();
            this.label_발명가 = new System.Windows.Forms.Label();
            this.label_CPCs = new System.Windows.Forms.Label();
            this.label_explain = new System.Windows.Forms.Label();
            this.listView_save = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_search_save = new System.Windows.Forms.Button();
            this.btn_save_save = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(988, 148);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(144, 37);
            this.btn_category.TabIndex = 0;
            this.btn_category.Text = "카테고리별 검색!";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.Btn_category_Click);
            // 
            // textBox_app_num
            // 
            this.textBox_app_num.Location = new System.Drawing.Point(130, 49);
            this.textBox_app_num.Name = "textBox_app_num";
            this.textBox_app_num.Size = new System.Drawing.Size(372, 25);
            this.textBox_app_num.TabIndex = 1;
            this.textBox_app_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_app_num_KeyDown);
            // 
            // textBox_app_date
            // 
            this.textBox_app_date.Location = new System.Drawing.Point(586, 49);
            this.textBox_app_date.Name = "textBox_app_date";
            this.textBox_app_date.Size = new System.Drawing.Size(372, 25);
            this.textBox_app_date.TabIndex = 2;
            this.textBox_app_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_app_date_KeyDown);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(130, 101);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(372, 25);
            this.textBox_title.TabIndex = 3;
            this.textBox_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_title_KeyDown);
            // 
            // textBox_abstract
            // 
            this.textBox_abstract.Location = new System.Drawing.Point(586, 101);
            this.textBox_abstract.Name = "textBox_abstract";
            this.textBox_abstract.Size = new System.Drawing.Size(372, 25);
            this.textBox_abstract.TabIndex = 4;
            this.textBox_abstract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_abstract_KeyDown);
            // 
            // textBox_inventors
            // 
            this.textBox_inventors.Location = new System.Drawing.Point(130, 153);
            this.textBox_inventors.Name = "textBox_inventors";
            this.textBox_inventors.Size = new System.Drawing.Size(372, 25);
            this.textBox_inventors.TabIndex = 5;
            this.textBox_inventors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_inventors_KeyDown);
            // 
            // textBox_CPCs
            // 
            this.textBox_CPCs.Location = new System.Drawing.Point(586, 156);
            this.textBox_CPCs.Name = "textBox_CPCs";
            this.textBox_CPCs.Size = new System.Drawing.Size(372, 25);
            this.textBox_CPCs.TabIndex = 6;
            this.textBox_CPCs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_CPCs_KeyDown);
            // 
            // listView_search
            // 
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.등록신청번호,
            this.출원일,
            this.특허명,
            this.초록,
            this.발명가,
            this.cps_});
            this.listView_search.FullRowSelect = true;
            this.listView_search.GridLines = true;
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(12, 231);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(596, 218);
            this.listView_search.TabIndex = 7;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_search_MouseDoubleClick);
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
            // label_등록신청번호
            // 
            this.label_등록신청번호.AutoSize = true;
            this.label_등록신청번호.Location = new System.Drawing.Point(23, 52);
            this.label_등록신청번호.Name = "label_등록신청번호";
            this.label_등록신청번호.Size = new System.Drawing.Size(97, 15);
            this.label_등록신청번호.TabIndex = 9;
            this.label_등록신청번호.Text = "등록신청번호";
            // 
            // label_출원일
            // 
            this.label_출원일.AutoSize = true;
            this.label_출원일.Location = new System.Drawing.Point(528, 52);
            this.label_출원일.Name = "label_출원일";
            this.label_출원일.Size = new System.Drawing.Size(52, 15);
            this.label_출원일.TabIndex = 10;
            this.label_출원일.Text = "출원일";
            // 
            // label_특허명
            // 
            this.label_특허명.AutoSize = true;
            this.label_특허명.Location = new System.Drawing.Point(40, 98);
            this.label_특허명.Name = "label_특허명";
            this.label_특허명.Size = new System.Drawing.Size(52, 15);
            this.label_특허명.TabIndex = 11;
            this.label_특허명.Text = "특허명";
            // 
            // label_초록
            // 
            this.label_초록.AutoSize = true;
            this.label_초록.Location = new System.Drawing.Point(535, 101);
            this.label_초록.Name = "label_초록";
            this.label_초록.Size = new System.Drawing.Size(37, 15);
            this.label_초록.TabIndex = 12;
            this.label_초록.Text = "초록";
            // 
            // label_발명가
            // 
            this.label_발명가.AutoSize = true;
            this.label_발명가.Location = new System.Drawing.Point(40, 156);
            this.label_발명가.Name = "label_발명가";
            this.label_발명가.Size = new System.Drawing.Size(52, 15);
            this.label_발명가.TabIndex = 13;
            this.label_발명가.Text = "발명가";
            // 
            // label_CPCs
            // 
            this.label_CPCs.AutoSize = true;
            this.label_CPCs.Location = new System.Drawing.Point(535, 156);
            this.label_CPCs.Name = "label_CPCs";
            this.label_CPCs.Size = new System.Drawing.Size(45, 15);
            this.label_CPCs.TabIndex = 14;
            this.label_CPCs.Text = "CPCs";
            // 
            // label_explain
            // 
            this.label_explain.AutoSize = true;
            this.label_explain.Location = new System.Drawing.Point(40, 198);
            this.label_explain.Name = "label_explain";
            this.label_explain.Size = new System.Drawing.Size(212, 15);
            this.label_explain.TabIndex = 15;
            this.label_explain.Text = "카테고리에 맞게 검색해주세요";
            // 
            // listView_save
            // 
            this.listView_save.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_save.FullRowSelect = true;
            this.listView_save.GridLines = true;
            this.listView_save.HideSelection = false;
            this.listView_save.Location = new System.Drawing.Point(682, 231);
            this.listView_save.Name = "listView_save";
            this.listView_save.Size = new System.Drawing.Size(570, 218);
            this.listView_save.TabIndex = 17;
            this.listView_save.UseCompatibleStateImageBehavior = false;
            this.listView_save.View = System.Windows.Forms.View.Details;
            this.listView_save.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_save_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "등록신청번호";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "출원일";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "특허명";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "초록";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "발명가";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CPCs";
            this.columnHeader6.Width = 87;
            // 
            // btn_search_save
            // 
            this.btn_search_save.Location = new System.Drawing.Point(12, 455);
            this.btn_search_save.Name = "btn_search_save";
            this.btn_search_save.Size = new System.Drawing.Size(126, 23);
            this.btn_search_save.TabIndex = 18;
            this.btn_search_save.Text = "검색기록 저장";
            this.btn_search_save.UseVisualStyleBackColor = true;
            this.btn_search_save.Click += new System.EventHandler(this.Btn_search_save_Click);
            // 
            // btn_save_save
            // 
            this.btn_save_save.Location = new System.Drawing.Point(682, 455);
            this.btn_save_save.Name = "btn_save_save";
            this.btn_save_save.Size = new System.Drawing.Size(130, 23);
            this.btn_save_save.TabIndex = 19;
            this.btn_save_save.Text = "장바구니 저장";
            this.btn_save_save.UseVisualStyleBackColor = true;
            this.btn_save_save.Click += new System.EventHandler(this.Btn_save_save_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(614, 315);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(62, 23);
            this.btn_plus.TabIndex = 20;
            this.btn_plus.Text = "추가";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(614, 363);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(62, 23);
            this.btn_minus.TabIndex = 21;
            this.btn_minus.Text = "삭제";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Btn_minus_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1148, 524);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(104, 23);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // category_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1259, 559);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_save_save);
            this.Controls.Add(this.btn_search_save);
            this.Controls.Add(this.listView_save);
            this.Controls.Add(this.label_explain);
            this.Controls.Add(this.label_CPCs);
            this.Controls.Add(this.label_발명가);
            this.Controls.Add(this.label_초록);
            this.Controls.Add(this.label_특허명);
            this.Controls.Add(this.label_출원일);
            this.Controls.Add(this.label_등록신청번호);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.textBox_CPCs);
            this.Controls.Add(this.textBox_inventors);
            this.Controls.Add(this.textBox_abstract);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_app_date);
            this.Controls.Add(this.textBox_app_num);
            this.Controls.Add(this.btn_category);
            this.Name = "category_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "카테고리별 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.TextBox textBox_app_num;
        private System.Windows.Forms.TextBox textBox_app_date;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_abstract;
        private System.Windows.Forms.TextBox textBox_inventors;
        private System.Windows.Forms.TextBox textBox_CPCs;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader 등록신청번호;
        private System.Windows.Forms.ColumnHeader 출원일;
        private System.Windows.Forms.ColumnHeader 특허명;
        private System.Windows.Forms.ColumnHeader 초록;
        private System.Windows.Forms.ColumnHeader 발명가;
        private System.Windows.Forms.ColumnHeader cps_;
        private System.Windows.Forms.Label label_등록신청번호;
        private System.Windows.Forms.Label label_출원일;
        private System.Windows.Forms.Label label_특허명;
        private System.Windows.Forms.Label label_초록;
        private System.Windows.Forms.Label label_발명가;
        private System.Windows.Forms.Label label_CPCs;
        private System.Windows.Forms.Label label_explain;
        private System.Windows.Forms.ListView listView_save;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_search_save;
        private System.Windows.Forms.Button btn_save_save;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_close;
    }
}