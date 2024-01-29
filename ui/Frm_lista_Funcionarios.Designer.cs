namespace ui
{
    partial class Frm_lista_Funcionarios
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
            this.Dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.colum_id_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluM_fun_correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fun_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fun_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_sex_fun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cplum_fun_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fun_editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colum_fun_borrar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_funcionarios
            // 
            this.Dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_id_funcionario,
            this.coluM_fun_correo,
            this.colum_fun_nombre,
            this.colum_fun_apellido,
            this.colum_sex_fun,
            this.cplum_fun_rol,
            this.colum_fun_editar,
            this.colum_fun_borrar});
            this.Dgv_funcionarios.Location = new System.Drawing.Point(47, 12);
            this.Dgv_funcionarios.Name = "Dgv_funcionarios";
            this.Dgv_funcionarios.RowTemplate.Height = 24;
            this.Dgv_funcionarios.Size = new System.Drawing.Size(840, 241);
            this.Dgv_funcionarios.TabIndex = 0;
            this.Dgv_funcionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionarios_CellClick);
            // 
            // colum_id_funcionario
            // 
            this.colum_id_funcionario.HeaderText = "Id";
            this.colum_id_funcionario.Name = "colum_id_funcionario";
            this.colum_id_funcionario.ReadOnly = true;
            // 
            // coluM_fun_correo
            // 
            this.coluM_fun_correo.FillWeight = 150F;
            this.coluM_fun_correo.HeaderText = "Correo";
            this.coluM_fun_correo.Name = "coluM_fun_correo";
            this.coluM_fun_correo.ReadOnly = true;
            this.coluM_fun_correo.Width = 140;
            // 
            // colum_fun_nombre
            // 
            this.colum_fun_nombre.HeaderText = "Nombre";
            this.colum_fun_nombre.Name = "colum_fun_nombre";
            this.colum_fun_nombre.ReadOnly = true;
            // 
            // colum_fun_apellido
            // 
            this.colum_fun_apellido.HeaderText = "Apellido";
            this.colum_fun_apellido.Name = "colum_fun_apellido";
            this.colum_fun_apellido.ReadOnly = true;
            // 
            // colum_sex_fun
            // 
            this.colum_sex_fun.HeaderText = "Sexo";
            this.colum_sex_fun.Name = "colum_sex_fun";
            this.colum_sex_fun.ReadOnly = true;
            // 
            // cplum_fun_rol
            // 
            this.cplum_fun_rol.HeaderText = "Rol";
            this.cplum_fun_rol.Name = "cplum_fun_rol";
            this.cplum_fun_rol.ReadOnly = true;
            // 
            // colum_fun_editar
            // 
            this.colum_fun_editar.HeaderText = "Editar";
            this.colum_fun_editar.Image = global::ui.Properties.Resources._27_Edit_Text_256x256_35395;
            this.colum_fun_editar.Name = "colum_fun_editar";
            this.colum_fun_editar.ReadOnly = true;
            // 
            // colum_fun_borrar
            // 
            this.colum_fun_borrar.HeaderText = "Borrar";
            this.colum_fun_borrar.Image = global::ui.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.colum_fun_borrar.Name = "colum_fun_borrar";
            this.colum_fun_borrar.ReadOnly = true;
            // 
            // Frm_lista_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 284);
            this.Controls.Add(this.Dgv_funcionarios);
            this.Name = "Frm_lista_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Funcionario";
            this.Load += new System.EventHandler(this.Frm_lista_Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_id_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluM_fun_correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fun_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fun_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_sex_fun;
        private System.Windows.Forms.DataGridViewTextBoxColumn cplum_fun_rol;
        private System.Windows.Forms.DataGridViewImageColumn colum_fun_editar;
        private System.Windows.Forms.DataGridViewImageColumn colum_fun_borrar;
    }
}