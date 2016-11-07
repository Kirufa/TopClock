namespace Clock
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLbl = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeLbl.Location = new System.Drawing.Point(0, 0);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(2);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(141, 33);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "06:30:21.5";
            this.timeLbl.SizeChanged += new System.EventHandler(this.timeLbl_SizeChanged);
            this.timeLbl.Paint += new System.Windows.Forms.PaintEventHandler(this.timeLbl_Paint);
            this.timeLbl.DoubleClick += new System.EventHandler(this.timeLbl_DoubleClick);
            this.timeLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseClick);
            this.timeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseDown);
            this.timeLbl.MouseLeave += new System.EventHandler(this.timeLbl_MouseLeave);
            this.timeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseMove);
            this.timeLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseUp);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Location = new System.Drawing.Point(11, 36);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(139, 24);
            this.pictureBoxBack.TabIndex = 1;
            this.pictureBoxBack.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 89);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.timeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}

