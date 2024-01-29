namespace ui
{
    partial class frm_lista_de_pacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lista_de_pacientes));
            this.dgv_listapaciente = new System.Windows.Forms.DataGridView();
            this.colum_idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nombrepaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_pacienteapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_telefonopaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_pacientesexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_pacienteruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_documentopaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_pacienteFechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_editpaciente = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_borrarpaciente = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listapaciente
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listapaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listapaciente.ColumnHeadersHeight = 40;
            this.dgv_listapaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_idpaciente,
            this.dgv_nombrepaciente,
            this.dgv_pacienteapellido,
            this.colum_telefonopaciente,
            this.colum_pacientesexo,
            this.colum_pacienteruc,
            this.colum_documentopaciente,
            this.colum_pacienteFechanacimiento,
            this.colum_editpaciente,
            this.Column_borrarpaciente});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listapaciente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_listapaciente.Location = new System.Drawing.Point(12, 12);
            this.dgv_listapaciente.Name = "dgv_listapaciente";
            this.dgv_listapaciente.RowTemplate.Height = 24;
            this.dgv_listapaciente.Size = new System.Drawing.Size(1031, 357);
            this.dgv_listapaciente.TabIndex = 0;
            this.dgv_listapaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listapaciente_CellClick);
            // 
            // colum_idpaciente
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.colum_idpaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.colum_idpaciente.HeaderText = "Id";
            this.colum_idpaciente.Name = "colum_idpaciente";
            this.colum_idpaciente.ReadOnly = true;
            this.colum_idpaciente.Width = 50;
            // 
            // dgv_nombrepaciente
            // 
            this.dgv_nombrepaciente.HeaderText = "Nombre";
            this.dgv_nombrepaciente.Name = "dgv_nombrepaciente";
            this.dgv_nombrepaciente.ReadOnly = true;
            // 
            // dgv_pacienteapellido
            // 
            this.dgv_pacienteapellido.HeaderText = "Apellido";
            this.dgv_pacienteapellido.Name = "dgv_pacienteapellido";
            this.dgv_pacienteapellido.ReadOnly = true;
            // 
            // colum_telefonopaciente
            // 
            this.colum_telefonopaciente.HeaderText = "Telefono";
            this.colum_telefonopaciente.Name = "colum_telefonopaciente";
            this.colum_telefonopaciente.ReadOnly = true;
            // 
            // colum_pacientesexo
            // 
            this.colum_pacientesexo.HeaderText = "Sexo";
            this.colum_pacientesexo.Name = "colum_pacientesexo";
            this.colum_pacientesexo.ReadOnly = true;
            // 
            // colum_pacienteruc
            // 
            this.colum_pacienteruc.HeaderText = "Ruc";
            this.colum_pacienteruc.Name = "colum_pacienteruc";
            this.colum_pacienteruc.ReadOnly = true;
            // 
            // colum_documentopaciente
            // 
            this.colum_documentopaciente.HeaderText = "Documento";
            this.colum_documentopaciente.Name = "colum_documentopaciente";
            // 
            // colum_pacienteFechanacimiento
            // 
            this.colum_pacienteFechanacimiento.HeaderText = "Fecha de Nacimiento";
            this.colum_pacienteFechanacimiento.Name = "colum_pacienteFechanacimiento";
            this.colum_pacienteFechanacimiento.ReadOnly = true;
            this.colum_pacienteFechanacimiento.Width = 150;
            // 
            // colum_editpaciente
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.colum_editpaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.colum_editpaciente.HeaderText = "Editar";
            this.colum_editpaciente.Image = ((System.Drawing.Image)(resources.GetObject("colum_editpaciente.Image")));
            this.colum_editpaciente.Name = "colum_editpaciente";
            this.colum_editpaciente.ReadOnly = true;
            this.colum_editpaciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colum_editpaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_borrarpaciente
            // 
            this.Column_borrarpaciente.HeaderText = "Borrar";
            this.Column_borrarpaciente.Image = ((System.Drawing.Image)(resources.GetObject("Column_borrarpaciente.Image")));
            this.Column_borrarpaciente.Name = "Column_borrarpaciente";
            this.Column_borrarpaciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_borrarpaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_lista_de_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 381);
            this.Controls.Add(this.dgv_listapaciente);
            this.Name = "frm_lista_de_pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de pacientes";
            this.Load += new System.EventHandler(this.frm_lista_de_pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listapaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_idpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nombrepaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_pacienteapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_telefonopaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_pacientesexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_pacienteruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_documentopaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_pacienteFechanacimiento;
        private System.Windows.Forms.DataGridViewImageColumn colum_editpaciente;
        private System.Windows.Forms.DataGridViewImageColumn Column_borrarpaciente;
    }
}