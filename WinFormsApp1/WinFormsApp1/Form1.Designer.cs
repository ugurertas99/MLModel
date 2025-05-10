namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoy = new TextBox();
            lblSonuc = new Label();
            btnTahminEt = new Button();
            SuspendLayout();
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(220, 142);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(100, 23);
            txtBoy.TabIndex = 0;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(350, 145);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(40, 15);
            lblSonuc.TabIndex = 1;
            lblSonuc.Text = "Sonuç";
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(272, 221);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(75, 23);
            btnTahminEt.TabIndex = 2;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTahminEt);
            Controls.Add(lblSonuc);
            Controls.Add(txtBoy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoy;
        private Label lblSonuc;
        private Button btnTahminEt;
    }
}
