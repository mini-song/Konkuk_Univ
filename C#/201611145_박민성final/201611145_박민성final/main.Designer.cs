namespace _201611145_박민성final
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_category_search = new System.Windows.Forms.PictureBox();
            this.pictureBox_precise_search = new System.Windows.Forms.PictureBox();
            this.textBox_quicksearch = new System.Windows.Forms.TextBox();
            this.btn_quicksearch = new System.Windows.Forms.Button();
            this.pictureBox_konkuk = new System.Windows.Forms.PictureBox();
            this.pictureBox_quick_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_category_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_precise_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_konkuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_quick_search)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_category_search
            // 
            this.pictureBox_category_search.Location = new System.Drawing.Point(30, 440);
            this.pictureBox_category_search.Name = "pictureBox_category_search";
            this.pictureBox_category_search.Size = new System.Drawing.Size(526, 191);
            this.pictureBox_category_search.TabIndex = 0;
            this.pictureBox_category_search.TabStop = false;
            this.pictureBox_category_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_category_search_MouseClick);
            this.pictureBox_category_search.MouseLeave += new System.EventHandler(this.PictureBox_category_search_MouseLeave);
            this.pictureBox_category_search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_category_search_MouseMove);
            // 
            // pictureBox_precise_search
            // 
            this.pictureBox_precise_search.Location = new System.Drawing.Point(30, 637);
            this.pictureBox_precise_search.Name = "pictureBox_precise_search";
            this.pictureBox_precise_search.Size = new System.Drawing.Size(526, 184);
            this.pictureBox_precise_search.TabIndex = 4;
            this.pictureBox_precise_search.TabStop = false;
            this.pictureBox_precise_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_precise_search_MouseClick);
            this.pictureBox_precise_search.MouseLeave += new System.EventHandler(this.PictureBox_precise_search_MouseLeave);
            this.pictureBox_precise_search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_precise_search_MouseMove);
            // 
            // textBox_quicksearch
            // 
            this.textBox_quicksearch.Location = new System.Drawing.Point(45, 400);
            this.textBox_quicksearch.Name = "textBox_quicksearch";
            this.textBox_quicksearch.Size = new System.Drawing.Size(373, 25);
            this.textBox_quicksearch.TabIndex = 7;
            this.textBox_quicksearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_quicksearch_KeyDown);
            // 
            // btn_quicksearch
            // 
            this.btn_quicksearch.Location = new System.Drawing.Point(424, 400);
            this.btn_quicksearch.Name = "btn_quicksearch";
            this.btn_quicksearch.Size = new System.Drawing.Size(120, 28);
            this.btn_quicksearch.TabIndex = 8;
            this.btn_quicksearch.Text = "빠른 검색";
            this.btn_quicksearch.UseVisualStyleBackColor = true;
            this.btn_quicksearch.Click += new System.EventHandler(this.Btn_quicksearch_Click);
            // 
            // pictureBox_konkuk
            // 
            this.pictureBox_konkuk.Location = new System.Drawing.Point(45, 20);
            this.pictureBox_konkuk.Name = "pictureBox_konkuk";
            this.pictureBox_konkuk.Size = new System.Drawing.Size(511, 192);
            this.pictureBox_konkuk.TabIndex = 9;
            this.pictureBox_konkuk.TabStop = false;
            // 
            // pictureBox_quick_search
            // 
            this.pictureBox_quick_search.Location = new System.Drawing.Point(30, 232);
            this.pictureBox_quick_search.Name = "pictureBox_quick_search";
            this.pictureBox_quick_search.Size = new System.Drawing.Size(526, 202);
            this.pictureBox_quick_search.TabIndex = 10;
            this.pictureBox_quick_search.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 843);
            this.Controls.Add(this.btn_quicksearch);
            this.Controls.Add(this.textBox_quicksearch);
            this.Controls.Add(this.pictureBox_quick_search);
            this.Controls.Add(this.pictureBox_konkuk);
            this.Controls.Add(this.pictureBox_precise_search);
            this.Controls.Add(this.pictureBox_category_search);
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "특허 검색기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_category_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_precise_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_konkuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_quick_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_category_search;
        private System.Windows.Forms.PictureBox pictureBox_precise_search;
        private System.Windows.Forms.TextBox textBox_quicksearch;
        private System.Windows.Forms.Button btn_quicksearch;
        private System.Windows.Forms.PictureBox pictureBox_konkuk;
        private System.Windows.Forms.PictureBox pictureBox_quick_search;
    }
}

