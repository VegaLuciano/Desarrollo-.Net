namespace WF_Ejercicio_I01
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
            lblNombre = new Label();
            lblDireccion = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            npdEdad = new NumericUpDown();
            gpbDatosUsuario = new GroupBox();
            chkC = new CheckBox();
            chkJavascript = new CheckBox();
            chkCSharp = new CheckBox();
            gpbCursos = new GroupBox();
            lstPais = new ListBox();
            lblPais = new Label();
            rdoMasculino = new RadioButton();
            rdoNobinario = new RadioButton();
            rdoFemenino = new RadioButton();
            gpbGenero = new GroupBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)npdEdad).BeginInit();
            gpbDatosUsuario.SuspendLayout();
            gpbCursos.SuspendLayout();
            gpbGenero.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 60);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(15, 90);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(97, 57);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 4;
            // 
            // npdEdad
            // 
            npdEdad.Location = new Point(97, 90);
            npdEdad.Name = "npdEdad";
            npdEdad.Size = new Size(100, 23);
            npdEdad.TabIndex = 5;
            // 
            // gpbDatosUsuario
            // 
            gpbDatosUsuario.Controls.Add(npdEdad);
            gpbDatosUsuario.Controls.Add(txtDireccion);
            gpbDatosUsuario.Controls.Add(txtNombre);
            gpbDatosUsuario.Controls.Add(lblEdad);
            gpbDatosUsuario.Controls.Add(lblDireccion);
            gpbDatosUsuario.Controls.Add(lblNombre);
            gpbDatosUsuario.Location = new Point(12, 12);
            gpbDatosUsuario.Name = "gpbDatosUsuario";
            gpbDatosUsuario.Size = new Size(213, 132);
            gpbDatosUsuario.TabIndex = 6;
            gpbDatosUsuario.TabStop = false;
            gpbDatosUsuario.Text = "DatosDelUsiario";
            // 
            // chkC
            // 
            chkC.AutoSize = true;
            chkC.Location = new Point(23, 22);
            chkC.Name = "chkC";
            chkC.Size = new Size(34, 19);
            chkC.TabIndex = 7;
            chkC.Text = "C";
            chkC.UseVisualStyleBackColor = true;
            // 
            // chkJavascript
            // 
            chkJavascript.AutoSize = true;
            chkJavascript.Location = new Point(23, 71);
            chkJavascript.Name = "chkJavascript";
            chkJavascript.Size = new Size(77, 19);
            chkJavascript.TabIndex = 8;
            chkJavascript.Text = "Javascript";
            chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(23, 47);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(41, 19);
            chkCSharp.TabIndex = 9;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            gpbCursos.Controls.Add(chkCSharp);
            gpbCursos.Controls.Add(chkJavascript);
            gpbCursos.Controls.Add(chkC);
            gpbCursos.Location = new Point(247, 130);
            gpbCursos.Name = "gpbCursos";
            gpbCursos.Size = new Size(115, 96);
            gpbCursos.TabIndex = 10;
            gpbCursos.TabStop = false;
            gpbCursos.Text = "Cursos";
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lstPais.Location = new Point(27, 166);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(120, 94);
            lstPais.TabIndex = 11;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(27, 148);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 12;
            lblPais.Text = "País";
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(17, 22);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(75, 19);
            rdoMasculino.TabIndex = 13;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Maculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoNobinario
            // 
            rdoNobinario.AutoSize = true;
            rdoNobinario.Location = new Point(17, 68);
            rdoNobinario.Name = "rdoNobinario";
            rdoNobinario.Size = new Size(81, 19);
            rdoNobinario.TabIndex = 14;
            rdoNobinario.TabStop = true;
            rdoNobinario.Text = "No binario";
            rdoNobinario.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(17, 43);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(78, 19);
            rdoFemenino.TabIndex = 15;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // gpbGenero
            // 
            gpbGenero.Controls.Add(rdoFemenino);
            gpbGenero.Controls.Add(rdoNobinario);
            gpbGenero.Controls.Add(rdoMasculino);
            gpbGenero.Location = new Point(247, 24);
            gpbGenero.Name = "gpbGenero";
            gpbGenero.Size = new Size(111, 100);
            gpbGenero.TabIndex = 16;
            gpbGenero.TabStop = false;
            gpbGenero.Text = "Genero";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(247, 237);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(111, 23);
            btnIngresar.TabIndex = 17;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 284);
            Controls.Add(btnIngresar);
            Controls.Add(gpbGenero);
            Controls.Add(lblPais);
            Controls.Add(lstPais);
            Controls.Add(gpbCursos);
            Controls.Add(gpbDatosUsuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)npdEdad).EndInit();
            gpbDatosUsuario.ResumeLayout(false);
            gpbDatosUsuario.PerformLayout();
            gpbCursos.ResumeLayout(false);
            gpbCursos.PerformLayout();
            gpbGenero.ResumeLayout(false);
            gpbGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDireccion;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private NumericUpDown npdEdad;
        private GroupBox gpbDatosUsuario;
        private CheckBox chkC;
        private CheckBox chkJavascript;
        private CheckBox chkCSharp;
        private GroupBox gpbCursos;
        private ListBox lstPais;
        private Label lblPais;
        private RadioButton rdoMasculino;
        private RadioButton rdoNobinario;
        private RadioButton rdoFemenino;
        private GroupBox gpbGenero;
        private Button btnIngresar;
    }
}