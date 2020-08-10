namespace SysInventory
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdScan = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CmdCompare = new System.Windows.Forms.Button();
            this.LblScan = new System.Windows.Forms.Label();
            this.CmdUploadFileOne = new System.Windows.Forms.Button();
            this.LblScanFileOne = new System.Windows.Forms.Label();
            this.Lbox1 = new System.Windows.Forms.ListBox();
            this.Lbox2 = new System.Windows.Forms.ListBox();
            this.LblListBox1 = new System.Windows.Forms.Label();
            this.LblListBox2 = new System.Windows.Forms.Label();
            this.LBoxScanList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdFilter = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LBoxFilteredScanList = new System.Windows.Forms.ListBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(28, 23);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(250, 47);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scan";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // CmdCompare
            // 
            this.CmdCompare.Location = new System.Drawing.Point(34, 668);
            this.CmdCompare.Name = "CmdCompare";
            this.CmdCompare.Size = new System.Drawing.Size(250, 47);
            this.CmdCompare.TabIndex = 1;
            this.CmdCompare.Text = "Vergleichen";
            this.CmdCompare.UseVisualStyleBackColor = true;
            this.CmdCompare.Click += new System.EventHandler(this.CmdCompare_Click);
            // 
            // LblScan
            // 
            this.LblScan.AutoSize = true;
            this.LblScan.Location = new System.Drawing.Point(284, 45);
            this.LblScan.Name = "LblScan";
            this.LblScan.Size = new System.Drawing.Size(0, 25);
            this.LblScan.TabIndex = 2;
            // 
            // CmdUploadFileOne
            // 
            this.CmdUploadFileOne.Location = new System.Drawing.Point(28, 87);
            this.CmdUploadFileOne.Name = "CmdUploadFileOne";
            this.CmdUploadFileOne.Size = new System.Drawing.Size(250, 47);
            this.CmdUploadFileOne.TabIndex = 3;
            this.CmdUploadFileOne.Text = "Durchsuchen...";
            this.CmdUploadFileOne.UseVisualStyleBackColor = true;
            this.CmdUploadFileOne.Click += new System.EventHandler(this.CmdUploadFileOne_Click);
            // 
            // LblScanFileOne
            // 
            this.LblScanFileOne.AutoSize = true;
            this.LblScanFileOne.Location = new System.Drawing.Point(284, 98);
            this.LblScanFileOne.Name = "LblScanFileOne";
            this.LblScanFileOne.Size = new System.Drawing.Size(68, 25);
            this.LblScanFileOne.TabIndex = 5;
            this.LblScanFileOne.Text = "Pfad: ";
            // 
            // Lbox1
            // 
            this.Lbox1.FormattingEnabled = true;
            this.Lbox1.ItemHeight = 25;
            this.Lbox1.Location = new System.Drawing.Point(34, 819);
            this.Lbox1.Name = "Lbox1";
            this.Lbox1.Size = new System.Drawing.Size(540, 279);
            this.Lbox1.TabIndex = 7;
            // 
            // Lbox2
            // 
            this.Lbox2.FormattingEnabled = true;
            this.Lbox2.ItemHeight = 25;
            this.Lbox2.Location = new System.Drawing.Point(621, 819);
            this.Lbox2.Name = "Lbox2";
            this.Lbox2.Size = new System.Drawing.Size(540, 279);
            this.Lbox2.TabIndex = 8;
            // 
            // LblListBox1
            // 
            this.LblListBox1.AutoSize = true;
            this.LblListBox1.Location = new System.Drawing.Point(29, 779);
            this.LblListBox1.Name = "LblListBox1";
            this.LblListBox1.Size = new System.Drawing.Size(130, 25);
            this.LblListBox1.TabIndex = 9;
            this.LblListBox1.Text = "Erster Scan ";
            // 
            // LblListBox2
            // 
            this.LblListBox2.AutoSize = true;
            this.LblListBox2.Location = new System.Drawing.Point(616, 779);
            this.LblListBox2.Name = "LblListBox2";
            this.LblListBox2.Size = new System.Drawing.Size(143, 25);
            this.LblListBox2.TabIndex = 10;
            this.LblListBox2.Text = "Zweiter Scan ";
            // 
            // LBoxScanList
            // 
            this.LBoxScanList.FormattingEnabled = true;
            this.LBoxScanList.ItemHeight = 25;
            this.LBoxScanList.Location = new System.Drawing.Point(28, 351);
            this.LBoxScanList.Name = "LBoxScanList";
            this.LBoxScanList.Size = new System.Drawing.Size(540, 279);
            this.LBoxScanList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scanliste";
            // 
            // CmdFilter
            // 
            this.CmdFilter.Location = new System.Drawing.Point(28, 153);
            this.CmdFilter.Name = "CmdFilter";
            this.CmdFilter.Size = new System.Drawing.Size(250, 47);
            this.CmdFilter.TabIndex = 14;
            this.CmdFilter.Text = "Filtern";
            this.CmdFilter.UseVisualStyleBackColor = true;
            this.CmdFilter.Click += new System.EventHandler(this.CmdFilter_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(300, 159);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(393, 31);
            this.DatePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Auswahl";
            // 
            // LBoxFilteredScanList
            // 
            this.LBoxFilteredScanList.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.LBoxFilteredScanList.FormattingEnabled = true;
            this.LBoxFilteredScanList.ItemHeight = 25;
            this.LBoxFilteredScanList.Location = new System.Drawing.Point(924, 351);
            this.LBoxFilteredScanList.Name = "LBoxFilteredScanList";
            this.LBoxFilteredScanList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBoxFilteredScanList.Size = new System.Drawing.Size(540, 279);
            this.LBoxFilteredScanList.TabIndex = 16;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(621, 374);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(250, 47);
            this.CmdAdd.TabIndex = 18;
            this.CmdAdd.Text = "Hinzufügen";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdRemove
            // 
            this.CmdRemove.Location = new System.Drawing.Point(621, 463);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(250, 47);
            this.CmdRemove.TabIndex = 19;
            this.CmdRemove.Text = "Entfernen";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 1187);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBoxFilteredScanList);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.CmdFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBoxScanList);
            this.Controls.Add(this.LblListBox2);
            this.Controls.Add(this.LblListBox1);
            this.Controls.Add(this.Lbox2);
            this.Controls.Add(this.Lbox1);
            this.Controls.Add(this.LblScanFileOne);
            this.Controls.Add(this.CmdUploadFileOne);
            this.Controls.Add(this.LblScan);
            this.Controls.Add(this.CmdCompare);
            this.Controls.Add(this.CmdScan);
            this.Name = "Form1";
            this.Text = "SysInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdScan;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button CmdCompare;
        private System.Windows.Forms.Label LblScan;
        private System.Windows.Forms.Button CmdUploadFileOne;
        private System.Windows.Forms.Label LblScanFileOne;
        private System.Windows.Forms.ListBox Lbox1;
        private System.Windows.Forms.ListBox Lbox2;
        private System.Windows.Forms.Label LblListBox1;
        private System.Windows.Forms.Label LblListBox2;
        private System.Windows.Forms.ListBox LBoxScanList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdFilter;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBoxFilteredScanList;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdRemove;
    }
}

