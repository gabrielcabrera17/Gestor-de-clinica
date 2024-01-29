using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Maping;

namespace ui
{
    public partial class frm_funcionarios : Form
    {
        private Funcionario objfuncionario;
        public frm_funcionarios()
        {
            InitializeComponent();
        }
        public void setFuncionario(Funcionario funcionario)
        {
            objfuncionario = funcionario;
        }

        private void lblfuncionario_apellido_Click(object sender, EventArgs e)
        {

        }

     

        private void btnfuncionario_cancelar_Click(object sender, EventArgs e)
        {
            txtfuncionario_nombre.Text = "";
            txtfuncionario_apellido.Text = "";
            txtfuncionario_correo.Text = "";
            txtfuncionario_rol.Text = "";
            cb_sexofuncionario.Text = "";
            this.Close();
        }

        private void frm_funcionarios_Load(object sender, EventArgs e)
        {
          
          
           cb_sexofuncionario.DataSource = new BindingSource(Genero.obtenerDatos(), "");
           cb_sexofuncionario.DisplayMember = "descripcion";
           cb_sexofuncionario.ValueMember = "id";
           cb_sexofuncionario.SelectedIndex = -1;

            if(0 != objfuncionario.id)
            {
                txtfuncionario_nombre.Text = objfuncionario.Nomnbre;
                txtfuncionario_apellido.Text = objfuncionario.Apellido;
                txtfuncionario_correo.Text = objfuncionario.Correo;
                txtfuncionario_rol.Text = objfuncionario.Rol;
                if(null != objfuncionario.Sexo)
                {
                    cb_sexofuncionario.SelectedValue = objfuncionario.Sexo;
                }
            }

        }

        private void txtfuncionario_correo_Leave(object sender, EventArgs e)
        {
            objfuncionario.Correo = txtfuncionario_correo.Text;
        }

        private void txtfuncionario_nombre_Leave(object sender, EventArgs e)
        {
            objfuncionario.Nomnbre = txtfuncionario_nombre.Text;
        }

        private void txtfuncionario_apellido_Leave(object sender, EventArgs e)
        {
            objfuncionario.Apellido = txtfuncionario_apellido.Text;
        }

        private void txtfuncionario_rol_Leave(object sender, EventArgs e)
        {
            objfuncionario.Rol = txtfuncionario_rol.Text;
        }
        private void cb_sexofuncionario_Leave(object sender, EventArgs e)
        {
            Genero sex = (Genero)cb_sexofuncionario.SelectedItem;
            objfuncionario.Sexo = sex;
            objfuncionario.Guardar();
        }



        private void btnfuncionario_guardar_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(objfuncionario.ToString());
        }

       
    }
}
