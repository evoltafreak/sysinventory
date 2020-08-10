namespace SysInventory.View
{
    partial class ScanDetail
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
            this.TxtScan = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtScan
            // 
            this.TxtScan.Location = new System.Drawing.Point(12, 12);
            this.TxtScan.Multiline = true;
            this.TxtScan.Name = "TxtScan";
            this.TxtScan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtScan.Size = new System.Drawing.Size(760, 378);
            this.TxtScan.TabIndex = 0;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(26, 407);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(190, 42);
            this.CmdCancel.TabIndex = 1;
            this.CmdCancel.Text = "Schliessen";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(234, 407);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(190, 42);
            this.CmdDelete.TabIndex = 2;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // ScanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.TxtScan);
            this.Name = "ScanDetail";
            this.Text = "ScanDetail";
            this.Shown += new System.EventHandler(this.ScanDetail_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtScan;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdDelete;
    }
}