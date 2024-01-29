namespace ui
{
    partial class frm_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_funcionarios));
            this.lblfuncionario_titulo = new System.Windows.Forms.Label();
            this.lblfuncionario_correo = new System.Windows.Forms.Label();
            this.txtfuncionario_correo = new System.Windows.Forms.TextBox();
            this.lblfuncionario_nombre = new System.Windows.Forms.Label();
            this.txtfuncionario_nombre = new System.Windows.Forms.TextBox();
            this.lblfuncionario_apellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtfuncionario_apellido = new System.Windows.Forms.TextBox();
            this.lblfuncionario_sexo = new System.Windows.Forms.Label();
            this.cb_sexofuncionario = new System.Windows.Forms.ComboBox();
            this.lblfuncionario_rol = new System.Windows.Forms.Label();
            this.txtfuncionario_rol = new System.Windows.Forms.TextBox();
            this.btnfuncionario_guardar = new System.Windows.Forms.Button();
            this.btnfuncionario_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfuncionario_titulo
            // 
            this.lblfuncionario_titulo.AutoSize = true;
            this.lblfuncionario_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncionario_titulo.Location = new System.Drawing.Point(97, 9);
            this.lblfuncionario_titulo.Name = "lblfuncionario_titulo";
            this.lblfuncionario_titulo.Size = new System.Drawing.Size(274, 20);
            this.lblfuncionario_titulo.TabIndex = 0;
            this.lblfuncionario_titulo.Text = "Administración de Funcionarios";
            // 
            // lblfuncionario_correo
            // 
            this.lblfuncionario_correo.AutoSize = true;
            this.lblfuncionario_correo.Location = new System.Drawing.Point(101, 54);
            this.lblfuncionario_correo.Name = "lblfuncionario_correo";
            this.lblfuncionario_correo.Size = new System.Drawing.Size(51, 17);
            this.lblfuncionario_correo.TabIndex = 1;
            this.lblfuncionario_correo.Text = "Correo";
            // 
            // txtfuncionario_correo
            // 
            this.txtfuncionario_correo.Location = new System.Drawing.Point(158, 48);
            this.txtfuncionario_correo.Name = "txtfuncionario_correo";
            this.txtfuncionario_correo.Size = new System.Drawing.Size(183, 22);
            this.txtfuncionario_correo.TabIndex = 2;
            this.txtfuncionario_correo.Leave += new System.EventHandler(this.txtfuncionario_correo_Leave);
            // 
            // lblfuncionario_nombre
            // 
            this.lblfuncionario_nombre.AutoSize = true;
            this.lblfuncionario_nombre.Location = new System.Drawing.Point(101, 80);
            this.lblfuncionario_nombre.Name = "lblfuncionario_nombre";
            this.lblfuncionario_nombre.Size = new System.Drawing.Size(58, 17);
            this.lblfuncionario_nombre.TabIndex = 3;
            this.lblfuncionario_nombre.Text = "Nombre";
            // 
            // txtfuncionario_nombre
            // 
            this.txtfuncionario_nombre.Location = new System.Drawing.Point(158, 80);
            this.txtfuncionario_nombre.Name = "txtfuncionario_nombre";
            this.txtfuncionario_nombre.Size = new System.Drawing.Size(183, 22);
            this.txtfuncionario_nombre.TabIndex = 4;
            this.txtfuncionario_nombre.Leave += new System.EventHandler(this.txtfuncionario_nombre_Leave);
            // 
            // lblfuncionario_apellido
            // 
            this.lblfuncionario_apellido.AutoSize = true;
            this.lblfuncionario_apellido.Location = new System.Drawing.Point(101, 113);
            this.lblfuncionario_apellido.Name = "lblfuncionario_apellido";
            this.lblfuncionario_apellido.Size = new System.Drawing.Size(58, 17);
            this.lblfuncionario_apellido.TabIndex = 5;
            this.lblfuncionario_apellido.Text = "Apellido";
            this.lblfuncionario_apellido.Click += new System.EventHandler(this.lblfuncionario_apellido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 6;
            // 
            // txtfuncionario_apellido
            // 
            this.txtfuncionario_apellido.Location = new System.Drawing.Point(158, 108);
            this.txtfuncionario_apellido.Name = "txtfuncionario_apellido";
            this.txtfuncionario_apellido.Size = new System.Drawing.Size(183, 22);
            this.txtfuncionario_apellido.TabIndex = 6;
            this.txtfuncionario_apellido.Leave += new System.EventHandler(this.txtfuncionario_apellido_Leave);
            // 
            // lblfuncionario_sexo
            // 
            this.lblfuncionario_sexo.AutoSize = true;
            this.lblfuncionario_sexo.Location = new System.Drawing.Point(101, 146);
            this.lblfuncionario_sexo.Name = "lblfuncionario_sexo";
            this.lblfuncionario_sexo.Size = new System.Drawing.Size(39, 17);
            this.lblfuncionario_sexo.TabIndex = 7;
            this.lblfuncionario_sexo.Text = "Sexo";
            // 
            // cb_sexofuncionario
            // 
            this.cb_sexofuncionario.FormattingEnabled = true;
            this.cb_sexofuncionario.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_sexofuncionario.Location = new System.Drawing.Point(158, 139);
            this.cb_sexofuncionario.Name = "cb_sexofuncionario";
            this.cb_sexofuncionario.Size = new System.Drawing.Size(183, 24);
            this.cb_sexofuncionario.TabIndex = 8;
            this.cb_sexofuncionario.Leave += new System.EventHandler(this.cb_sexofuncionario_Leave);
            // 
            // lblfuncionario_rol
            // 
            this.lblfuncionario_rol.AutoSize = true;
            this.lblfuncionario_rol.Location = new System.Drawing.Point(101, 176);
            this.lblfuncionario_rol.Name = "lblfuncionario_rol";
            this.lblfuncionario_rol.Size = new System.Drawing.Size(29, 17);
            this.lblfuncionario_rol.TabIndex = 9;
            this.lblfuncionario_rol.Text = "Rol";
            // 
            // txtfuncionario_rol
            // 
            this.txtfuncionario_rol.Location = new System.Drawing.Point(158, 169);
            this.txtfuncionario_rol.Name = "txtfuncionario_rol";
            this.txtfuncionario_rol.Size = new System.Drawing.Size(183, 22);
            this.txtfuncionario_rol.TabIndex = 10;
            this.txtfuncionario_rol.Leave += new System.EventHandler(this.txtfuncionario_rol_Leave);
            // 
            // btnfuncionario_guardar
            // 
            this.btnfuncionario_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btnfuncionario_guardar.Image")));
            this.btnfuncionario_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfuncionario_guardar.Location = new System.Drawing.Point(101, 273);
            this.btnfuncionario_guardar.Name = "btnfuncionario_guardar";
            this.btnfuncionario_guardar.Size = new System.Drawing.Size(89, 27);
            this.btnfuncionario_guardar.TabIndex = 11;
            this.btnfuncionario_guardar.Text = "Guardar";
            this.btnfuncionario_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfuncionario_guardar.UseVisualStyleBackColor = true;
            this.btnfuncionario_guardar.Click += new System.EventHandler(this.btnfuncionario_guardar_Click);
            // 
            // btnfuncionario_cancelar
            // 
            this.btnfuncionario_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnfuncionario_cancelar.Image")));
            this.btnfuncionario_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfuncionario_cancelar.Location = new System.Drawing.Point(237, 273);
            this.btnfuncionario_cancelar.Name = "btnfuncionario_cancelar";
            this.btnfuncionario_cancelar.Size = new System.Drawing.Size(93, 27);
            this.btnfuncionario_cancelar.TabIndex = 12;
            this.btnfuncionario_cancelar.Text = "Cancelar";
            this.btnfuncionario_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfuncionario_cancelar.UseVisualStyleBackColor = true;
            this.btnfuncionario_cancelar.Click += new System.EventHandler(this.btnfuncionario_cancelar_Click);
            // 
            // frm_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnfuncionario_cancelar);
            this.Controls.Add(this.btnfuncionario_guardar);
            this.Controls.Add(this.txtfuncionario_rol);
            this.Controls.Add(this.lblfuncionario_rol);
            this.Controls.Add(this.cb_sexofuncionario);
            this.Controls.Add(this.lblfuncionario_sexo);
            this.Controls.Add(this.txtfuncionario_apellido);
            this.Controls.Add(this.lblfuncionario_apellido);
            this.Controls.Add(this.txtfuncionario_nombre);
            this.Controls.Add(this.lblfuncionario_nombre);
            this.Controls.Add(this.txtfuncionario_correo);
            this.Controls.Add(this.lblfuncionario_correo);
            this.Controls.Add(this.lblfuncionario_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.frm_funcionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfuncionario_titulo;
        private System.Windows.Forms.Label lblfuncionario_correo;
        private System.Windows.Forms.TextBox txtfuncionario_correo;
        private System.Windows.Forms.Label lblfuncionario_nombre;
        private System.Windows.Forms.TextBox txtfuncionario_nombre;
        private System.Windows.Forms.Label lblfuncionario_apellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtfuncionario_apellido;
        private System.Windows.Forms.Label lblfuncionario_sexo;
        private System.Windows.Forms.ComboBox cb_sexofuncionario;
        private System.Windows.Forms.Label lblfuncionario_rol;
        private System.Windows.Forms.TextBox txtfuncionario_rol;
        private System.Windows.Forms.Button btnfuncionario_guardar;
        private System.Windows.Forms.Button btnfuncionario_cancelar;
    }
}