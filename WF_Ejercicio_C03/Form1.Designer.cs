namespace WF_Ejercicio_C03
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
            lblBinarioADecimal = new Label();
            lblDeciamlABinario = new Label();
            txtBinario = new TextBox();
            txtDecimal = new TextBox();
            btnBinToDec = new Button();
            btnDecToBin = new Button();
            txtResultadoDec = new TextBox();
            txtResultadoBin = new TextBox();
            SuspendLayout();
            // 
            // lblBinarioADecimal
            // 
            lblBinarioADecimal.AutoSize = true;
            lblBinarioADecimal.Location = new Point(39, 38);
            lblBinarioADecimal.Name = "lblBinarioADecimal";
            lblBinarioADecimal.Size = new Size(99, 15);
            lblBinarioADecimal.TabIndex = 0;
            lblBinarioADecimal.Text = "Binario a Decimal";
            // 
            // lblDeciamlABinario
            // 
            lblDeciamlABinario.AutoSize = true;
            lblDeciamlABinario.Location = new Point(39, 76);
            lblDeciamlABinario.Name = "lblDeciamlABinario";
            lblDeciamlABinario.Size = new Size(99, 15);
            lblDeciamlABinario.TabIndex = 1;
            lblDeciamlABinario.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(158, 34);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(100, 23);
            txtBinario.TabIndex = 2;
            txtBinario.TextChanged += txtBinario_TextChanged;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(158, 73);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(100, 23);
            txtDecimal.TabIndex = 3;
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(279, 34);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(75, 23);
            btnBinToDec.TabIndex = 4;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(279, 72);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(75, 23);
            btnDecToBin.TabIndex = 5;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // txtResultadoDec
            // 
            txtResultadoDec.Location = new Point(382, 34);
            txtResultadoDec.Name = "txtResultadoDec";
            txtResultadoDec.ReadOnly = true;
            txtResultadoDec.Size = new Size(100, 23);
            txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            txtResultadoBin.Location = new Point(382, 72);
            txtResultadoBin.Name = "txtResultadoBin";
            txtResultadoBin.ReadOnly = true;
            txtResultadoBin.Size = new Size(100, 23);
            txtResultadoBin.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 126);
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

        private Label lblBinarioADecimal;
        private Label lblDeciamlABinario;
        private TextBox txtBinario;
        private TextBox txtDecimal;
        private Button btnBinToDec;
        private Button btnDecToBin;
        private TextBox txtResultadoDec;
        private TextBox txtResultadoBin;
    }
}