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
            this.components = new System.ComponentModel.Container();
            this.timeLbl = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.rightCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.moveToCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_TopMost = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.rightCMS.SuspendLayout();
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
            // rightCMS
            // 
            this.rightCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacityToolStripMenuItem,
            this.moveToCenterToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.topMostToolStripMenuItem});
            this.rightCMS.Name = "rightCMS";
            this.rightCMS.Size = new System.Drawing.Size(166, 114);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.opacityToolStripMenuItem.Text = "Opacity";
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox.Text = "0.75";
            this.toolStripTextBox.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
            // 
            // moveToCenterToolStripMenuItem
            // 
            this.moveToCenterToolStripMenuItem.Name = "moveToCenterToolStripMenuItem";
            this.moveToCenterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moveToCenterToolStripMenuItem.Text = "Move To Center";
            this.moveToCenterToolStripMenuItem.Click += new System.EventHandler(this.moveToCenterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_TopMost});
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.topMostToolStripMenuItem.Text = "TopMost";
            // 
            // toolStripTextBox_TopMost
            // 
            this.toolStripTextBox_TopMost.Name = "toolStripTextBox_TopMost";
            this.toolStripTextBox_TopMost.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_TopMost.Text = "true";
            this.toolStripTextBox_TopMost.TextChanged += new System.EventHandler(this.toolStripTextBox_TopMost_TextChanged);
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
            this.rightCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.ContextMenuStrip rightCMS;
        private System.Windows.Forms.ToolStripMenuItem moveToCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_TopMost;
    }
}

