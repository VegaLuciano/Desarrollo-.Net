namespace Prueba_WF
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
            txtResultadoBin = new TextBox();
            txtResultadoDec = new TextBox();
            btnDecToBin = new Button();
            btnBinToDec = new Button();
            txtDecimal = new TextBox();
            txtBinario = new TextBox();
            lblDeciamlABinario = new Label();
            lblBinarioADecimal = new Label();
            SuspendLayout();
            // 
            // txtResultadoBin
            // 
            txtResultadoBin.Location = new Point(421, 86);
            txtResultadoBin.Name = "txtResultadoBin";
            txtResultadoBin.ReadOnly = true;
            txtResultadoBin.Size = new Size(100, 23);
            txtResultadoBin.TabIndex = 15;
            // 
            // txtResultadoDec
            // 
            txtResultadoDec.Location = new Point(421, 48);
            txtResultadoDec.Name = "txtResultadoDec";
            txtResultadoDec.ReadOnly = true;
            txtResultadoDec.Size = new Size(100, 23);
            txtResultadoDec.TabIndex = 14;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(318, 86);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(75, 23);
            btnDecToBin.TabIndex = 13;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(318, 48);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(75, 23);
            btnBinToDec.TabIndex = 12;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(197, 87);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(100, 23);
            txtDecimal.TabIndex = 11;
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(197, 48);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(100, 23);
            txtBinario.TabIndex = 10;
            // 
            // lblDeciamlABinario
            // 
            lblDeciamlABinario.AutoSize = true;
            lblDeciamlABinario.Location = new Point(78, 90);
            lblDeciamlABinario.Name = "lblDeciamlABinario";
            lblDeciamlABinario.Size = new Size(99, 15);
            lblDeciamlABinario.TabIndex = 9;
            lblDeciamlABinario.Text = "Decimal a Binario";
            // 
            // lblBinarioADecimal
            // 
            lblBinarioADecimal.AutoSize = true;
            lblBinarioADecimal.Location = new Point(78, 52);
            lblBinarioADecimal.Name = "lblBinarioADecimal";
            lblBinarioADecimal.Size = new Size(99, 15);
            lblBinarioADecimal.TabIndex = 8;
            lblBinarioADecimal.Text = "Binario a Decimal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 172);
            Controls.Add(txtResultadoBin);
            Controls.Add(txtResultadoDec);
            Controls.Add(btnDecToBin);
            Controls.Add(btnBinToDec);
            Controls.Add(txtDecimal);
            Controls.Add(txtBinario);
            Controls.Add(lblDeciamlABinario);
            Controls.Add(lblBinarioADecimal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultadoBin;
        private TextBox txtResultadoDec;
        private Button btnDecToBin;
        private Button btnBinToDec;
        private TextBox txtDecimal;
        private TextBox txtBinario;
        private Label lblDeciamlABinario;
        private Label lblBinarioADecimal;
    }
}