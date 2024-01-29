namespace ui
{
    partial class frm_listade_doctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listade_doctores));
            this.dgv_especialidades = new System.Windows.Forms.DataGridView();
            this.colum_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_especialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colm_doctornombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_apellido_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_documento_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_sexo_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_telefonodoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_ruc_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colum_borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_especialidades
            // 
            this.dgv_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_especialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_id,
            this.colum_especialidades,
            this.colm_doctornombre,
            this.colum_apellido_doctor,
            this.colum_documento_doctor,
            this.colum_sexo_doctor,
            this.colum_telefonodoctor,
            this.colum_ruc_doctor,
            this.colum_edit,
            this.colum_borrar});
            this.dgv_especialidades.Location = new System.Drawing.Point(12, 21);
            this.dgv_especialidades.Name = "dgv_especialidades";
            this.dgv_especialidades.RowTemplate.Height = 24;
            this.dgv_especialidades.Size = new System.Drawing.Size(1173, 356);
            this.dgv_especialidades.TabIndex = 0;
            this.dgv_especialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_especialidades_CellContentClick);
            // 
            // colum_id
            // 
            this.colum_id.HeaderText = "ID";
            this.colum_id.Name = "colum_id";
            this.colum_id.ReadOnly = true;
            // 
            // colum_especialidades
            // 
            this.colum_especialidades.HeaderText = "Especialidades";
            this.colum_especialidades.MinimumWidth = 7;
            this.colum_especialidades.Name = "colum_especialidades";
            this.colum_especialidades.ReadOnly = true;
            this.colum_especialidades.Width = 150;
            // 
            // colm_doctornombre
            // 
            this.colm_doctornombre.HeaderText = "Nombre";
            this.colm_doctornombre.Name = "colm_doctornombre";
            this.colm_doctornombre.ReadOnly = true;
            // 
            // colum_apellido_doctor
            // 
            this.colum_apellido_doctor.HeaderText = "Apellido";
            this.colum_apellido_doctor.Name = "colum_apellido_doctor";
            this.colum_apellido_doctor.ReadOnly = true;
            // 
            // colum_documento_doctor
            // 
            this.colum_documento_doctor.HeaderText = "Documento";
            this.colum_documento_doctor.Name = "colum_documento_doctor";
            this.colum_documento_doctor.ReadOnly = true;
            // 
            // colum_sexo_doctor
            // 
            this.colum_sexo_doctor.HeaderText = "Sexo";
            this.colum_sexo_doctor.Name = "colum_sexo_doctor";
            this.colum_sexo_doctor.ReadOnly = true;
            // 
            // colum_telefonodoctor
            // 
            this.colum_telefonodoctor.HeaderText = "Telefono";
            this.colum_telefonodoctor.Name = "colum_telefonodoctor";
            this.colum_telefonodoctor.ReadOnly = true;
            // 
            // colum_ruc_doctor
            // 
            this.colum_ruc_doctor.HeaderText = "Ruc";
            this.colum_ruc_doctor.Name = "colum_ruc_doctor";
            this.colum_ruc_doctor.ReadOnly = true;
            // 
            // colum_edit
            // 
            this.colum_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colum_edit.FillWeight = 150F;
            this.colum_edit.HeaderText = "Editar";
            this.colum_edit.Image = ((System.Drawing.Image)(resources.GetObject("colum_edit.Image")));
            this.colum_edit.Name = "colum_edit";
            this.colum_edit.ReadOnly = true;
            this.colum_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colum_edit.Width = 74;
            // 
            // colum_borrar
            // 
            this.colum_borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colum_borrar.HeaderText = "Borrar";
            this.colum_borrar.Image = ((System.Drawing.Image)(resources.GetObject("colum_borrar.Image")));
            this.colum_borrar.Name = "colum_borrar";
            this.colum_borrar.ReadOnly = true;
            this.colum_borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colum_borrar.Width = 77;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ui.Properties.Resources.Image_edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_listade_doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 369);
            this.Controls.Add(this.dgv_especialidades);
            this.Name = "frm_listade_doctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de doctores";
            this.Load += new System.EventHandler(this.frm_listade_especialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_especialidades;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_especialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colm_doctornombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_apellido_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_documento_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_sexo_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_telefonodoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ruc_doctor;
        private System.Windows.Forms.DataGridViewImageColumn colum_edit;
        private System.Windows.Forms.DataGridViewImageColumn colum_borrar;
    }
}