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
    public partial class frm_ConsultaPaciente : Form
    {
        private Paciente objpaciente;
        public frm_ConsultaPaciente()
        {
            InitializeComponent();
        }
        public void setPaciente(Paciente paciente)
        {
            objpaciente = paciente;
        }

        private void cmbmujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultaPaciente_Load(object sender, EventArgs e)
        {
            

            cb_sexopaciente.DataSource = new BindingSource(Genero.obtenerDatos(), "");
            cb_sexopaciente.DisplayMember = "descripcion";
            cb_sexopaciente.ValueMember = "id";
            cb_sexopaciente.SelectedIndex = -1;

            if (0 != objpaciente.id)
            {
                txtnombre_paciente.Text = objpaciente.Nombre;
                txtapellido_paciente.Text = objpaciente.Apellido;
                txtdocumento_paciente.Text = objpaciente.Documento;
                txttelefono_paciente.Text = objpaciente.Telefono;
                objpaciente.Fecha = dtpregistropaciente.Value;
                
                
                if(null != objpaciente.Sexo)
                {
                    cb_sexopaciente.SelectedValue = objpaciente.Sexo; // SelectedValue, esta permite tomar el valor del ítem seleccionado por el usuario, pero como manipular esta propiedad depende de la forma en como se haya vinculado el control al origen de datos.
                }
                txtruc_paciente.Text = objpaciente.Ruc;
            }

        }





        private void txtnombre_paciente_Leave(object sender, EventArgs e)
        {
            objpaciente.Nombre = txtnombre_paciente.Text;
      
          
        }

        private void txtapellido_paciente_Leave(object sender, EventArgs e)
        {
            objpaciente.Apellido = txtapellido_paciente.Text;
        }

    

        private void txttelefono_paciente_Leave(object sender, EventArgs e)
        {
            objpaciente.Telefono = txttelefono_paciente.Text;
        }

        private void txtdocumento_paciente_Leave(object sender, EventArgs e)
        {
            objpaciente.Documento = txtdocumento_paciente.Text;
        }

        private void txtruc_paciente_Leave(object sender, EventArgs e)
        {
            objpaciente.Ruc = txtruc_paciente.Text;
        }
        private void cb_sexopaciente_Leave(object sender, EventArgs e)
        {
            Genero sexpac = (Genero)cb_sexopaciente.SelectedItem;
            objpaciente.Sexo = sexpac;
            objpaciente.Guardar();
        }


        private void btnguardar_paciente_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(objpaciente.ToString());
        }

        private void btncancelar_paciente_Click(object sender, EventArgs e)
        {
            txtruc_paciente.Text = "";
            txtnombre_paciente.Text = "";
            txtapellido_paciente.Text = "";
            txtdocumento_paciente.Text = "";
            txttelefono_paciente.Text = "";
            cb_sexopaciente.Text = "";

        }

        private void dtpregistropaciente_ValueChanged(object sender, EventArgs e)
        {
            objpaciente.Fecha = dtpregistropaciente.Value;
        }
    }
}
