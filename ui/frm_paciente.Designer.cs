namespace ui
{
    partial class frm_ConsultaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaPaciente));
            this.lbltituloPaciente = new System.Windows.Forms.Label();
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.lblapellidopaciente = new System.Windows.Forms.Label();
            this.lbltelefonopaciente = new System.Windows.Forms.Label();
            this.lblsexopaciente = new System.Windows.Forms.Label();
            this.lblfechadenacimientopaciente = new System.Windows.Forms.Label();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.lblrucpaciente = new System.Windows.Forms.Label();
            this.txtnombre_paciente = new System.Windows.Forms.TextBox();
            this.txtapellido_paciente = new System.Windows.Forms.TextBox();
            this.txttelefono_paciente = new System.Windows.Forms.TextBox();
            this.cb_sexopaciente = new System.Windows.Forms.ComboBox();
            this.dtpregistropaciente = new System.Windows.Forms.DateTimePicker();
            this.txtdocumento_paciente = new System.Windows.Forms.TextBox();
            this.txtruc_paciente = new System.Windows.Forms.TextBox();
            this.btnguardar_paciente = new System.Windows.Forms.Button();
            this.btncancelar_paciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltituloPaciente
            // 
            this.lbltituloPaciente.AutoSize = true;
            this.lbltituloPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloPaciente.Location = new System.Drawing.Point(146, 9);
            this.lbltituloPaciente.Name = "lbltituloPaciente";
            this.lbltituloPaciente.Size = new System.Drawing.Size(185, 20);
            this.lbltituloPaciente.TabIndex = 0;
            this.lbltituloPaciente.Text = "Registro de Paciente";
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.Location = new System.Drawing.Point(83, 55);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(58, 17);
            this.lblnombrepaciente.TabIndex = 1;
            this.lblnombrepaciente.Text = "Nombre";
            // 
            // lblapellidopaciente
            // 
            this.lblapellidopaciente.AutoSize = true;
            this.lblapellidopaciente.Location = new System.Drawing.Point(83, 83);
            this.lblapellidopaciente.Name = "lblapellidopaciente";
            this.lblapellidopaciente.Size = new System.Drawing.Size(58, 17);
            this.lblapellidopaciente.TabIndex = 2;
            this.lblapellidopaciente.Text = "Apellido";
            // 
            // lbltelefonopaciente
            // 
            this.lbltelefonopaciente.AutoSize = true;
            this.lbltelefonopaciente.Location = new System.Drawing.Point(83, 111);
            this.lbltelefonopaciente.Name = "lbltelefonopaciente";
            this.lbltelefonopaciente.Size = new System.Drawing.Size(64, 17);
            this.lbltelefonopaciente.TabIndex = 3;
            this.lbltelefonopaciente.Text = "Telefono";
            // 
            // lblsexopaciente
            // 
            this.lblsexopaciente.AutoSize = true;
            this.lblsexopaciente.Location = new System.Drawing.Point(83, 142);
            this.lblsexopaciente.Name = "lblsexopaciente";
            this.lblsexopaciente.Size = new System.Drawing.Size(39, 17);
            this.lblsexopaciente.TabIndex = 4;
            this.lblsexopaciente.Text = "Sexo";
            // 
            // lblfechadenacimientopaciente
            // 
            this.lblfechadenacimientopaciente.AutoSize = true;
            this.lblfechadenacimientopaciente.Location = new System.Drawing.Point(83, 188);
            this.lblfechadenacimientopaciente.Name = "lblfechadenacimientopaciente";
            this.lblfechadenacimientopaciente.Size = new System.Drawing.Size(141, 17);
            this.lblfechadenacimientopaciente.TabIndex = 5;
            this.lblfechadenacimientopaciente.Text = "Fecha de Nacimiento";
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Location = new System.Drawing.Point(83, 221);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(80, 17);
            this.lbldocumento.TabIndex = 6;
            this.lbldocumento.Text = "Documento";
            // 
            // lblrucpaciente
            // 
            this.lblrucpaciente.AutoSize = true;
            this.lblrucpaciente.Location = new System.Drawing.Point(83, 247);
            this.lblrucpaciente.Name = "lblrucpaciente";
            this.lblrucpaciente.Size = new System.Drawing.Size(33, 17);
            this.lblrucpaciente.TabIndex = 7;
            this.lblrucpaciente.Text = "Ruc";
            // 
            // txtnombre_paciente
            // 
            this.txtnombre_paciente.Location = new System.Drawing.Point(147, 55);
            this.txtnombre_paciente.Name = "txtnombre_paciente";
            this.txtnombre_paciente.Size = new System.Drawing.Size(166, 22);
            this.txtnombre_paciente.TabIndex = 8;
            this.txtnombre_paciente.Leave += new System.EventHandler(this.txtnombre_paciente_Leave);
            // 
            // txtapellido_paciente
            // 
            this.txtapellido_paciente.Location = new System.Drawing.Point(147, 83);
            this.txtapellido_paciente.Name = "txtapellido_paciente";
            this.txtapellido_paciente.Size = new System.Drawing.Size(167, 22);
            this.txtapellido_paciente.TabIndex = 9;
            this.txtapellido_paciente.Leave += new System.EventHandler(this.txtapellido_paciente_Leave);
            // 
            // txttelefono_paciente
            // 
            this.txttelefono_paciente.Location = new System.Drawing.Point(147, 114);
            this.txttelefono_paciente.Name = "txttelefono_paciente";
            this.txttelefono_paciente.Size = new System.Drawing.Size(166, 22);
            this.txttelefono_paciente.TabIndex = 10;
            this.txttelefono_paciente.Leave += new System.EventHandler(this.txttelefono_paciente_Leave);
            // 
            // cb_sexopaciente
            // 
            this.cb_sexopaciente.FormattingEnabled = true;
            this.cb_sexopaciente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_sexopaciente.Location = new System.Drawing.Point(147, 142);
            this.cb_sexopaciente.Name = "cb_sexopaciente";
            this.cb_sexopaciente.Size = new System.Drawing.Size(121, 24);
            this.cb_sexopaciente.TabIndex = 12;
            this.cb_sexopaciente.Leave += new System.EventHandler(this.cb_sexopaciente_Leave);
            // 
            // dtpregistropaciente
            // 
            this.dtpregistropaciente.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpregistropaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpregistropaciente.Location = new System.Drawing.Point(230, 188);
            this.dtpregistropaciente.Name = "dtpregistropaciente";
            this.dtpregistropaciente.Size = new System.Drawing.Size(200, 22);
            this.dtpregistropaciente.TabIndex = 13;
            this.dtpregistropaciente.ValueChanged += new System.EventHandler(this.dtpregistropaciente_ValueChanged);
            // 
            // txtdocumento_paciente
            // 
            this.txtdocumento_paciente.Location = new System.Drawing.Point(169, 216);
            this.txtdocumento_paciente.Name = "txtdocumento_paciente";
            this.txtdocumento_paciente.Size = new System.Drawing.Size(132, 22);
            this.txtdocumento_paciente.TabIndex = 14;
            this.txtdocumento_paciente.Leave += new System.EventHandler(this.txtdocumento_paciente_Leave);
            // 
            // txtruc_paciente
            // 
            this.txtruc_paciente.Location = new System.Drawing.Point(147, 244);
            this.txtruc_paciente.Name = "txtruc_paciente";
            this.txtruc_paciente.Size = new System.Drawing.Size(121, 22);
            this.txtruc_paciente.TabIndex = 15;
            this.txtruc_paciente.Leave += new System.EventHandler(this.txtruc_paciente_Leave);
            // 
            // btnguardar_paciente
            // 
            this.btnguardar_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btnguardar_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar_paciente.Image")));
            this.btnguardar_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar_paciente.Location = new System.Drawing.Point(72, 345);
            this.btnguardar_paciente.Name = "btnguardar_paciente";
            this.btnguardar_paciente.Size = new System.Drawing.Size(91, 32);
            this.btnguardar_paciente.TabIndex = 16;
            this.btnguardar_paciente.Text = "Guardar";
            this.btnguardar_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar_paciente.UseVisualStyleBackColor = true;
            this.btnguardar_paciente.Click += new System.EventHandler(this.btnguardar_paciente_Click);
            // 
            // btncancelar_paciente
            // 
            this.btncancelar_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar_paciente.Image")));
            this.btncancelar_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar_paciente.Location = new System.Drawing.Point(248, 345);
            this.btncancelar_paciente.Name = "btncancelar_paciente";
            this.btncancelar_paciente.Size = new System.Drawing.Size(102, 32);
            this.btncancelar_paciente.TabIndex = 17;
            this.btncancelar_paciente.Text = "Cancelar";
            this.btncancelar_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar_paciente.UseVisualStyleBackColor = true;
            this.btncancelar_paciente.Click += new System.EventHandler(this.btncancelar_paciente_Click);
            // 
            // frm_ConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btncancelar_paciente);
            this.Controls.Add(this.btnguardar_paciente);
            this.Controls.Add(this.txtruc_paciente);
            this.Controls.Add(this.txtdocumento_paciente);
            this.Controls.Add(this.dtpregistropaciente);
            this.Controls.Add(this.cb_sexopaciente);
            this.Controls.Add(this.txttelefono_paciente);
            this.Controls.Add(this.txtapellido_paciente);
            this.Controls.Add(this.txtnombre_paciente);
            this.Controls.Add(this.lblrucpaciente);
            this.Controls.Add(this.lbldocumento);
            this.Controls.Add(this.lblfechadenacimientopaciente);
            this.Controls.Add(this.lblsexopaciente);
            this.Controls.Add(this.lbltelefonopaciente);
            this.Controls.Add(this.lblapellidopaciente);
            this.Controls.Add(this.lblnombrepaciente);
            this.Controls.Add(this.lbltituloPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ConsultaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsultaPaciente";
            this.Load += new System.EventHandler(this.FrmConsultaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltituloPaciente;
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.Label lblapellidopaciente;
        private System.Windows.Forms.Label lbltelefonopaciente;
        private System.Windows.Forms.Label lblsexopaciente;
        private System.Windows.Forms.Label lblfechadenacimientopaciente;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lblrucpaciente;
        private System.Windows.Forms.TextBox txtnombre_paciente;
        private System.Windows.Forms.TextBox txtapellido_paciente;
        private System.Windows.Forms.TextBox txttelefono_paciente;
        private System.Windows.Forms.ComboBox cb_sexopaciente;
        private System.Windows.Forms.DateTimePicker dtpregistropaciente;
        private System.Windows.Forms.TextBox txtdocumento_paciente;
        private System.Windows.Forms.TextBox txtruc_paciente;
        private System.Windows.Forms.Button btnguardar_paciente;
        private System.Windows.Forms.Button btncancelar_paciente;
    }
}