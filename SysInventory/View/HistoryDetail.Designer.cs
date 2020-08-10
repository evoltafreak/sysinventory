namespace SysInventory.View
{
    partial class HistoryDetail
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
            this.LBox1 = new System.Windows.Forms.ListBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdShowHistory = new System.Windows.Forms.Button();
            this.LBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBox1
            // 
            this.LBox1.FormattingEnabled = true;
            this.LBox1.ItemHeight = 25;
            this.LBox1.Location = new System.Drawing.Point(12, 12);
            this.LBox1.Name = "LBox1";
            this.LBox1.Size = new System.Drawing.Size(425, 329);
            this.LBox1.TabIndex = 0;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(12, 368);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(167, 49);
            this.CmdCancel.TabIndex = 1;
            this.CmdCancel.Text = "Schliessen";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click_1);
            // 
            // CmdShowHistory
            // 
            this.CmdShowHistory.Location = new System.Drawing.Point(520, 368);
            this.CmdShowHistory.Name = "CmdShowHistory";
            this.CmdShowHistory.Size = new System.Drawing.Size(225, 49);
            this.CmdShowHistory.TabIndex = 2;
            this.CmdShowHistory.Text = "History anzeigen";
            this.CmdShowHistory.UseVisualStyleBackColor = true;
            this.CmdShowHistory.Click += new System.EventHandler(this.CmdShowHistory_Click);
            // 
            // LBox2
            // 
            this.LBox2.FormattingEnabled = true;
            this.LBox2.ItemHeight = 25;
            this.LBox2.Location = new System.Drawing.Point(520, 12);
            this.LBox2.Name = "LBox2";
            this.LBox2.Size = new System.Drawing.Size(1022, 329);
            this.LBox2.TabIndex = 3;
            // 
            // HistoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 450);
            this.Controls.Add(this.LBox2);
            this.Controls.Add(this.CmdShowHistory);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.LBox1);
            this.Name = "HistoryDetail";
            this.Text = "HistoryDetail";
            this.Shown += new System.EventHandler(this.HistoryDetail_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBox1;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdShowHistory;
        private System.Windows.Forms.ListBox LBox2;
    }
}