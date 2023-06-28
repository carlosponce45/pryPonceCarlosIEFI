namespace pryPonceIEFI
{
    partial class pryPonceIEFI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbllugardenacimiento = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lbltipodesexo = new System.Windows.Forms.Label();
            this.lblingreso = new System.Windows.Forms.Label();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.comblugardenacimiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnmasculino = new System.Windows.Forms.RadioButton();
            this.rbnfemenino = new System.Windows.Forms.RadioButton();
            this.lbledad = new System.Windows.Forms.Label();
            this.umEdad = new System.Windows.Forms.NumericUpDown();
            this.btnpais = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblRegistrarPais = new System.Windows.Forms.Label();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.txtpuntaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.umEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(18, 82);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(60, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "NOMBRE :";
            // 
            // lbllugardenacimiento
            // 
            this.lbllugardenacimiento.AutoSize = true;
            this.lbllugardenacimiento.Location = new System.Drawing.Point(12, 185);
            this.lbllugardenacimiento.Name = "lbllugardenacimiento";
            this.lbllugardenacimiento.Size = new System.Drawing.Size(135, 13);
            this.lbllugardenacimiento.TabIndex = 1;
            this.lbllugardenacimiento.Text = "LUGAR DE NACIMIENTO:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(12, 114);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(62, 13);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "APELLIDO:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(132, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(132, 107);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 5;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // lbltipodesexo
            // 
            this.lbltipodesexo.AutoSize = true;
            this.lbltipodesexo.Location = new System.Drawing.Point(12, 227);
            this.lbltipodesexo.Name = "lbltipodesexo";
            this.lbltipodesexo.Size = new System.Drawing.Size(85, 13);
            this.lbltipodesexo.TabIndex = 6;
            this.lbltipodesexo.Text = "TIPO DE SEXO:";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Location = new System.Drawing.Point(19, 274);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(59, 13);
            this.lblingreso.TabIndex = 9;
            this.lblingreso.Text = "INGRESO:";
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Location = new System.Drawing.Point(12, 334);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(59, 13);
            this.lblpuntaje.TabIndex = 11;
            this.lblpuntaje.Text = "PUNTAJE:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(22, 385);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 13;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click_1);
            // 
            // comblugardenacimiento
            // 
            this.comblugardenacimiento.FormattingEnabled = true;
            this.comblugardenacimiento.Location = new System.Drawing.Point(188, 177);
            this.comblugardenacimiento.Name = "comblugardenacimiento";
            this.comblugardenacimiento.Size = new System.Drawing.Size(121, 21);
            this.comblugardenacimiento.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "CLUB LOS SAUCE";
            // 
            // rbnmasculino
            // 
            this.rbnmasculino.AutoSize = true;
            this.rbnmasculino.Location = new System.Drawing.Point(132, 223);
            this.rbnmasculino.Name = "rbnmasculino";
            this.rbnmasculino.Size = new System.Drawing.Size(88, 17);
            this.rbnmasculino.TabIndex = 17;
            this.rbnmasculino.TabStop = true;
            this.rbnmasculino.Text = "MASCULINO";
            this.rbnmasculino.UseVisualStyleBackColor = true;
            this.rbnmasculino.CheckedChanged += new System.EventHandler(this.rbnmasculino_CheckedChanged);
            // 
            // rbnfemenino
            // 
            this.rbnfemenino.AutoSize = true;
            this.rbnfemenino.Location = new System.Drawing.Point(243, 223);
            this.rbnfemenino.Name = "rbnfemenino";
            this.rbnfemenino.Size = new System.Drawing.Size(81, 17);
            this.rbnfemenino.TabIndex = 18;
            this.rbnfemenino.TabStop = true;
            this.rbnfemenino.Text = "FEMENINO";
            this.rbnfemenino.UseVisualStyleBackColor = true;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(12, 149);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 13);
            this.lbledad.TabIndex = 19;
            this.lbledad.Text = "EDAD:";
            // 
            // umEdad
            // 
            this.umEdad.Enabled = false;
            this.umEdad.Location = new System.Drawing.Point(132, 142);
            this.umEdad.Name = "umEdad";
            this.umEdad.Size = new System.Drawing.Size(100, 20);
            this.umEdad.TabIndex = 20;
            this.umEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.umEdad.ValueChanged += new System.EventHandler(this.umEdad_ValueChanged);
            // 
            // btnpais
            // 
            this.btnpais.Location = new System.Drawing.Point(117, 465);
            this.btnpais.Name = "btnpais";
            this.btnpais.Size = new System.Drawing.Size(75, 23);
            this.btnpais.TabIndex = 23;
            this.btnpais.Text = "Agregar";
            this.btnpais.UseVisualStyleBackColor = true;
            this.btnpais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(92, 430);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 22;
            // 
            // lblRegistrarPais
            // 
            this.lblRegistrarPais.AutoSize = true;
            this.lblRegistrarPais.Location = new System.Drawing.Point(19, 433);
            this.lblRegistrarPais.Name = "lblRegistrarPais";
            this.lblRegistrarPais.Size = new System.Drawing.Size(67, 13);
            this.lblRegistrarPais.TabIndex = 21;
            this.lblRegistrarPais.Text = "Agregar Pais";
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(161, 267);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(100, 20);
            this.txtingreso.TabIndex = 24;
            this.txtingreso.TextChanged += new System.EventHandler(this.txtingreso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "PAIS:";
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(161, 294);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 26;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.cmbpais_SelectedIndexChanged);
            // 
            // txtpuntaje
            // 
            this.txtpuntaje.Location = new System.Drawing.Point(161, 331);
            this.txtpuntaje.Name = "txtpuntaje";
            this.txtpuntaje.Size = new System.Drawing.Size(100, 20);
            this.txtpuntaje.TabIndex = 27;
            this.txtpuntaje.TextChanged += new System.EventHandler(this.txtpuntaje_TextChanged);
            // 
            // pryPonceIEFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 489);
            this.Controls.Add(this.txtpuntaje);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.btnpais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblRegistrarPais);
            this.Controls.Add(this.umEdad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.rbnfemenino);
            this.Controls.Add(this.rbnmasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comblugardenacimiento);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblingreso);
            this.Controls.Add(this.lbltipodesexo);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lbllugardenacimiento);
            this.Controls.Add(this.lblnombre);
            this.Name = "pryPonceIEFI";
            this.Text = "pryPonceIEFI";
            ((System.ComponentModel.ISupportInitialize)(this.umEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbllugardenacimiento;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lbltipodesexo;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ComboBox comblugardenacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnmasculino;
        private System.Windows.Forms.RadioButton rbnfemenino;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.NumericUpDown umEdad;
        private System.Windows.Forms.Button btnpais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblRegistrarPais;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.TextBox txtpuntaje;
    }
}

