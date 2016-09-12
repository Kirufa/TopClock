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
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(0, 0);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(3);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(187, 38);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "06:30:21.5";
            this.timeLbl.SizeChanged += new System.EventHandler(this.timeLbl_SizeChanged);
            this.timeLbl.DoubleClick += new System.EventHandler(this.timeLbl_DoubleClick);
            this.timeLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseClick);
            this.timeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseDown);
            this.timeLbl.MouseLeave += new System.EventHandler(this.timeLbl_MouseLeave);
            this.timeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseMove);
            this.timeLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 111);
            this.Controls.Add(this.timeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
    }
}

