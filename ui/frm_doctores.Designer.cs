namespace ui
{
    partial class frm_doctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doctores));
            this.lbltitulo_doctor = new System.Windows.Forms.Label();
            this.lblnombre_doctor = new System.Windows.Forms.Label();
            this.txtdoctor_nombre = new System.Windows.Forms.TextBox();
            this.lbldoctor_apellido = new System.Windows.Forms.Label();
            this.txtdoctor_apellido = new System.Windows.Forms.TextBox();
            this.lbldoctor_telefono = new System.Windows.Forms.Label();
            this.txtdoctor_telefono = new System.Windows.Forms.TextBox();
            this.lbldocumento_doctores = new System.Windows.Forms.Label();
            this.txtdoctores_documentos = new System.Windows.Forms.TextBox();
            this.lbldoctor_ruc = new System.Windows.Forms.Label();
            this.txtdoctor_ruc = new System.Windows.Forms.TextBox();
            this.lbldoctor_sexo = new System.Windows.Forms.Label();
            this.cmbdoctor_sexo = new System.Windows.Forms.ComboBox();
            this.lbldoctor_especialidad = new System.Windows.Forms.Label();
            this.btndoctor_guardar = new System.Windows.Forms.Button();
            this.btndoctor_cancelar = new System.Windows.Forms.Button();
            this.cb_especialidaddoctor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbltitulo_doctor
            // 
            this.lbltitulo_doctor.AutoSize = true;
            this.lbltitulo_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo_doctor.Location = new System.Drawing.Point(141, 9);
            this.lbltitulo_doctor.Name = "lbltitulo_doctor";
            this.lbltitulo_doctor.Size = new System.Drawing.Size(138, 20);
            this.lbltitulo_doctor.TabIndex = 0;
            this.lbltitulo_doctor.Text = "Agregar Doctor";
            // 
            // lblnombre_doctor
            // 
            this.lblnombre_doctor.AutoSize = true;
            this.lblnombre_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblnombre_doctor.Location = new System.Drawing.Point(68, 47);
            this.lblnombre_doctor.Name = "lblnombre_doctor";
            this.lblnombre_doctor.Size = new System.Drawing.Size(62, 18);
            this.lblnombre_doctor.TabIndex = 1;
            this.lblnombre_doctor.Text = "Nombre";
            // 
            // txtdoctor_nombre
            // 
            this.txtdoctor_nombre.Location = new System.Drawing.Point(145, 42);
            this.txtdoctor_nombre.Name = "txtdoctor_nombre";
            this.txtdoctor_nombre.Size = new System.Drawing.Size(126, 22);
            this.txtdoctor_nombre.TabIndex = 2;
            this.txtdoctor_nombre.Leave += new System.EventHandler(this.txtdoctor_nombre_Leave);
            // 
            // lbldoctor_apellido
            // 
            this.lbldoctor_apellido.AutoSize = true;
            this.lbldoctor_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lbldoctor_apellido.Location = new System.Drawing.Point(68, 79);
            this.lbldoctor_apellido.Name = "lbldoctor_apellido";
            this.lbldoctor_apellido.Size = new System.Drawing.Size(59, 18);
            this.lbldoctor_apellido.TabIndex = 3;
            this.lbldoctor_apellido.Text = "Apellido";
            // 
            // txtdoctor_apellido
            // 
            this.txtdoctor_apellido.Location = new System.Drawing.Point(145, 75);
            this.txtdoctor_apellido.Name = "txtdoctor_apellido";
            this.txtdoctor_apellido.Size = new System.Drawing.Size(126, 22);
            this.txtdoctor_apellido.TabIndex = 4;
            this.txtdoctor_apellido.Leave += new System.EventHandler(this.txtdoctor_apellido_Leave);
            // 
            // lbldoctor_telefono
            // 
            this.lbldoctor_telefono.AutoSize = true;
            this.lbldoctor_telefono.Location = new System.Drawing.Point(68, 114);
            this.lbldoctor_telefono.Name = "lbldoctor_telefono";
            this.lbldoctor_telefono.Size = new System.Drawing.Size(64, 17);
            this.lbldoctor_telefono.TabIndex = 5;
            this.lbldoctor_telefono.Text = "Telefono";
            // 
            // txtdoctor_telefono
            // 
            this.txtdoctor_telefono.Location = new System.Drawing.Point(145, 108);
            this.txtdoctor_telefono.Name = "txtdoctor_telefono";
            this.txtdoctor_telefono.Size = new System.Drawing.Size(126, 22);
            this.txtdoctor_telefono.TabIndex = 6;
            this.txtdoctor_telefono.Leave += new System.EventHandler(this.txtdoctor_telefono_Leave);
            // 
            // lbldocumento_doctores
            // 
            this.lbldocumento_doctores.AutoSize = true;
            this.lbldocumento_doctores.Location = new System.Drawing.Point(68, 144);
            this.lbldocumento_doctores.Name = "lbldocumento_doctores";
            this.lbldocumento_doctores.Size = new System.Drawing.Size(80, 17);
            this.lbldocumento_doctores.TabIndex = 7;
            this.lbldocumento_doctores.Text = "Documento";
            // 
            // txtdoctores_documentos
            // 
            this.txtdoctores_documentos.Location = new System.Drawing.Point(145, 136);
            this.txtdoctores_documentos.Name = "txtdoctores_documentos";
            this.txtdoctores_documentos.Size = new System.Drawing.Size(126, 22);
            this.txtdoctores_documentos.TabIndex = 8;
            this.txtdoctores_documentos.Leave += new System.EventHandler(this.txtdoctores_documentos_Leave);
            // 
            // lbldoctor_ruc
            // 
            this.lbldoctor_ruc.AutoSize = true;
            this.lbldoctor_ruc.Location = new System.Drawing.Point(68, 171);
            this.lbldoctor_ruc.Name = "lbldoctor_ruc";
            this.lbldoctor_ruc.Size = new System.Drawing.Size(33, 17);
            this.lbldoctor_ruc.TabIndex = 9;
            this.lbldoctor_ruc.Text = "Ruc";
            // 
            // txtdoctor_ruc
            // 
            this.txtdoctor_ruc.Location = new System.Drawing.Point(145, 166);
            this.txtdoctor_ruc.Name = "txtdoctor_ruc";
            this.txtdoctor_ruc.Size = new System.Drawing.Size(126, 22);
            this.txtdoctor_ruc.TabIndex = 10;
            this.txtdoctor_ruc.Leave += new System.EventHandler(this.txtdoctor_ruc_Leave);
            // 
            // lbldoctor_sexo
            // 
            this.lbldoctor_sexo.AutoSize = true;
            this.lbldoctor_sexo.Location = new System.Drawing.Point(68, 201);
            this.lbldoctor_sexo.Name = "lbldoctor_sexo";
            this.lbldoctor_sexo.Size = new System.Drawing.Size(39, 17);
            this.lbldoctor_sexo.TabIndex = 11;
            this.lbldoctor_sexo.Text = "Sexo";
            // 
            // cmbdoctor_sexo
            // 
            this.cmbdoctor_sexo.FormattingEnabled = true;
            this.cmbdoctor_sexo.Items.AddRange(new object[] {
            ""});
            this.cmbdoctor_sexo.Location = new System.Drawing.Point(145, 201);
            this.cmbdoctor_sexo.Name = "cmbdoctor_sexo";
            this.cmbdoctor_sexo.Size = new System.Drawing.Size(126, 24);
            this.cmbdoctor_sexo.TabIndex = 12;
            this.cmbdoctor_sexo.Leave += new System.EventHandler(this.cmbdoctor_sexo_Leave);
            // 
            // lbldoctor_especialidad
            // 
            this.lbldoctor_especialidad.AutoSize = true;
            this.lbldoctor_especialidad.Location = new System.Drawing.Point(68, 246);
            this.lbldoctor_especialidad.Name = "lbldoctor_especialidad";
            this.lbldoctor_especialidad.Size = new System.Drawing.Size(88, 17);
            this.lbldoctor_especialidad.TabIndex = 13;
            this.lbldoctor_especialidad.Text = "Especialidad";
            // 
            // btndoctor_guardar
            // 
            this.btndoctor_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btndoctor_guardar.Image")));
            this.btndoctor_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndoctor_guardar.Location = new System.Drawing.Point(71, 310);
            this.btndoctor_guardar.Name = "btndoctor_guardar";
            this.btndoctor_guardar.Size = new System.Drawing.Size(92, 28);
            this.btndoctor_guardar.TabIndex = 15;
            this.btndoctor_guardar.Text = "Guardar";
            this.btndoctor_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndoctor_guardar.UseVisualStyleBackColor = true;
            this.btndoctor_guardar.Click += new System.EventHandler(this.btndoctor_guardar_Click);
            // 
            // btndoctor_cancelar
            // 
            this.btndoctor_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btndoctor_cancelar.Image")));
            this.btndoctor_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndoctor_cancelar.Location = new System.Drawing.Point(217, 310);
            this.btndoctor_cancelar.Name = "btndoctor_cancelar";
            this.btndoctor_cancelar.Size = new System.Drawing.Size(96, 28);
            this.btndoctor_cancelar.TabIndex = 16;
            this.btndoctor_cancelar.Text = "Cancelar";
            this.btndoctor_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndoctor_cancelar.UseVisualStyleBackColor = true;
            this.btndoctor_cancelar.Click += new System.EventHandler(this.btndoctor_cancelar_Click);
            // 
            // cb_especialidaddoctor
            // 
            this.cb_especialidaddoctor.FormattingEnabled = true;
            this.cb_especialidaddoctor.Items.AddRange(new object[] {
            "Cardiologo",
            "Pediatra",
            "Cirujano",
            "Dermatologia",
            "Clinico"});
            this.cb_especialidaddoctor.Location = new System.Drawing.Point(162, 243);
            this.cb_especialidaddoctor.Name = "cb_especialidaddoctor";
            this.cb_especialidaddoctor.Size = new System.Drawing.Size(150, 24);
            this.cb_especialidaddoctor.TabIndex = 17;
            this.cb_especialidaddoctor.Leave += new System.EventHandler(this.cb_especialidaddoctor_Leave);
            // 
            // frm_doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.cb_especialidaddoctor);
            this.Controls.Add(this.btndoctor_cancelar);
            this.Controls.Add(this.btndoctor_guardar);
            this.Controls.Add(this.lbldoctor_especialidad);
            this.Controls.Add(this.cmbdoctor_sexo);
            this.Controls.Add(this.lbldoctor_sexo);
            this.Controls.Add(this.txtdoctor_ruc);
            this.Controls.Add(this.lbldoctor_ruc);
            this.Controls.Add(this.txtdoctores_documentos);
            this.Controls.Add(this.lbldocumento_doctores);
            this.Controls.Add(this.txtdoctor_telefono);
            this.Controls.Add(this.lbldoctor_telefono);
            this.Controls.Add(this.txtdoctor_apellido);
            this.Controls.Add(this.lbldoctor_apellido);
            this.Controls.Add(this.txtdoctor_nombre);
            this.Controls.Add(this.lblnombre_doctor);
            this.Controls.Add(this.lbltitulo_doctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_doctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.frm_doctores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo_doctor;
        private System.Windows.Forms.Label lblnombre_doctor;
        private System.Windows.Forms.TextBox txtdoctor_nombre;
        private System.Windows.Forms.Label lbldoctor_apellido;
        private System.Windows.Forms.TextBox txtdoctor_apellido;
        private System.Windows.Forms.Label lbldoctor_telefono;
        private System.Windows.Forms.TextBox txtdoctor_telefono;
        private System.Windows.Forms.Label lbldocumento_doctores;
        private System.Windows.Forms.TextBox txtdoctores_documentos;
        private System.Windows.Forms.Label lbldoctor_ruc;
        private System.Windows.Forms.TextBox txtdoctor_ruc;
        private System.Windows.Forms.Label lbldoctor_sexo;
        private System.Windows.Forms.ComboBox cmbdoctor_sexo;
        private System.Windows.Forms.Label lbldoctor_especialidad;
        private System.Windows.Forms.Button btndoctor_guardar;
        private System.Windows.Forms.Button btndoctor_cancelar;
        private System.Windows.Forms.ComboBox cb_especialidaddoctor;
    }
}