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
    public partial class frm_doctores : Form
    {
        private Doctor objdoctor;
        public frm_doctores()
        {
            InitializeComponent();
        }
        public void setDoctor(Doctor doctor)
        {
            objdoctor = doctor;
        }

        private void frm_doctores_Load(object sender, EventArgs e)
        {
          // Dato: para agregar nuevo doctor desde la grilla solo debe dejarse el objdoctor = new Doctor();, y crear un muevo icono en en la grilla para agrear así como editar y borrar con el mismo clickcell
            cmbdoctor_sexo.DataSource = new BindingSource(Genero.obtenerDatos(),"");
            cmbdoctor_sexo.DisplayMember = "descripcion";
            cmbdoctor_sexo.ValueMember = "id";
            cmbdoctor_sexo.SelectedIndex = -1;
            //Especialidad
            cb_especialidaddoctor.DataSource = new BindingSource(Especialidad.obtenerDatosEspecialidad(), "");
            cb_especialidaddoctor.DisplayMember = "descripcion";
            cb_especialidaddoctor.ValueMember = "id";
            cb_especialidaddoctor.SelectedIndex = -1;
            //Estableciendo la edición
            if(0 != objdoctor.id)
            {
                txtdoctor_nombre.Text = objdoctor.Nombre;
                txtdoctor_apellido.Text = objdoctor.Apellido;
                txtdoctor_ruc.Text = objdoctor.Ruc;
                txtdoctor_telefono.Text = objdoctor.Telefono;
                txtdoctores_documentos.Text = objdoctor.Documento;
                if(null != objdoctor.Sexo)
                {
                    cmbdoctor_sexo.SelectedValue = objdoctor.Sexo;
                }
                if(null != objdoctor.Especialidad)
                {
                    cb_especialidaddoctor.SelectedValue = objdoctor.Especialidad;
                }
            } 

        }

        private void txtdoctor_nombre_Leave(object sender, EventArgs e)
        {
            objdoctor.Nombre = txtdoctor_nombre.Text; 
        }

        private void txtdoctor_apellido_Leave(object sender, EventArgs e)
        {
            objdoctor.Apellido = txtdoctor_apellido.Text;
        }

        private void txtdoctor_telefono_Leave(object sender, EventArgs e)
        {
            objdoctor.Telefono = txtdoctor_telefono.Text;
        }

        private void txtdoctores_documentos_Leave(object sender, EventArgs e)
        {
            objdoctor.Documento = txtdoctores_documentos.Text;
        }

        private void txtdoctor_ruc_Leave(object sender, EventArgs e)
        {
            objdoctor.Ruc = txtdoctor_ruc.Text;
        }

       private void cmbdoctor_sexo_Leave(object sender, EventArgs e)
        {
            Genero genero = (Genero)cmbdoctor_sexo.SelectedItem;
            objdoctor.Sexo = genero;
            objdoctor.Guardar();
        }

       private void cb_especialidaddoctor_Leave(object sender, EventArgs e)
        {
            Especialidad espe = (Especialidad)cb_especialidaddoctor.SelectedItem;
            objdoctor.Especialidad = espe;
            objdoctor.Guardar();
            
        }


        private void btndoctor_guardar_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(objdoctor.ToString());
        }

        private void btndoctor_cancelar_Click(object sender, EventArgs e)
        {
            txtdoctor_nombre.Text = "";
            txtdoctor_apellido.Text = "";
            txtdoctor_telefono.Text = "";
            txtdoctores_documentos.Text = "";
            txtdoctor_ruc.Text = "";
            cb_especialidaddoctor.Text = "";
            cmbdoctor_sexo.Text = "";
        }

       
    }
}
