namespace BestOil_with_Database.Views
{
    partial class MainView
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.OilLbl = new System.Windows.Forms.Label();
            this.PayLbl = new System.Windows.Forms.Label();
            this.LiterLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LiterTxtb = new System.Windows.Forms.TextBox();
            this.PayTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(557, 270);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 21);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(654, 270);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(98, 21);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // OilLbl
            // 
            this.OilLbl.AutoSize = true;
            this.OilLbl.Location = new System.Drawing.Point(13, 31);
            this.OilLbl.Name = "OilLbl";
            this.OilLbl.Size = new System.Drawing.Size(19, 13);
            this.OilLbl.TabIndex = 2;
            this.OilLbl.Text = "Oil";
            // 
            // PayLbl
            // 
            this.PayLbl.AutoSize = true;
            this.PayLbl.Location = new System.Drawing.Point(12, 102);
            this.PayLbl.Name = "PayLbl";
            this.PayLbl.Size = new System.Drawing.Size(25, 13);
            this.PayLbl.TabIndex = 4;
            this.PayLbl.Text = "Pay";
            // 
            // LiterLbl
            // 
            this.LiterLbl.AutoSize = true;
            this.LiterLbl.Location = new System.Drawing.Point(12, 66);
            this.LiterLbl.Name = "LiterLbl";
            this.LiterLbl.Size = new System.Drawing.Size(27, 13);
            this.LiterLbl.TabIndex = 5;
            this.LiterLbl.Text = "Liter";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(557, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 199);
            this.listBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // LiterTxtb
            // 
            this.LiterTxtb.Location = new System.Drawing.Point(69, 63);
            this.LiterTxtb.Name = "LiterTxtb";
            this.LiterTxtb.Size = new System.Drawing.Size(100, 20);
            this.LiterTxtb.TabIndex = 8;
            // 
            // PayTxtBx
            // 
            this.PayTxtBx.Location = new System.Drawing.Point(69, 95);
            this.PayTxtBx.Name = "PayTxtBx";
            this.PayTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PayTxtBx.TabIndex = 9;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayTxtBx);
            this.Controls.Add(this.LiterTxtb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LiterLbl);
            this.Controls.Add(this.PayLbl);
            this.Controls.Add(this.OilLbl);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label OilLbl;
        private System.Windows.Forms.Label PayLbl;
        private System.Windows.Forms.Label LiterLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox LiterTxtb;
        private System.Windows.Forms.TextBox PayTxtBx;
    }
}