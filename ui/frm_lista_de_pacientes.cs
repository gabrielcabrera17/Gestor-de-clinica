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
    public partial class frm_lista_de_pacientes : Form
    {
        public frm_lista_de_pacientes()
        {
            InitializeComponent();
        }

        private void frm_lista_de_pacientes_Load(object sender, EventArgs e)
        {
            this.CargarTabla();
        }

        private void CargarTabla()
        {
            this.dgv_listapaciente.Rows.Clear();
            foreach (Paciente p in Paciente.obtenerDatos())
            {
                String[] fila = new String[]
                {
                    Convert.ToString(p.id),p.Nombre,p.Apellido,p.Telefono,p.Sexo.descripcion,p.Ruc,p.Documento,
                  p.Fecha.ToString("dd/MM/yyyy")
                };
                this.dgv_listapaciente.Rows.Add(fila);

            }
        

    }

        private void dgv_listapaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           // Paciente paciente = new Paciente();
              int idpaciente = Convert.ToInt32(dgv_listapaciente[0, e.RowIndex].Value);
                Paciente paciente = Utilitarios.Lista_paciente[idpaciente];



            if (e.ColumnIndex == 8)
            {
             
                frm_ConsultaPaciente formPaciente = new frm_ConsultaPaciente();
                formPaciente.setPaciente(paciente);
                formPaciente.ShowDialog();
                this.CargarTabla();

            } else if (e.ColumnIndex == 9)
            {
                //Paciente paciente = new Paciente();
                DialogResult pc = MessageBox.Show("¿ Estas seguro de que desea borrar al paciente: "+ paciente.Nombre+"?", "Eliminar Paciente",MessageBoxButtons.YesNo);
                if (pc.Equals(DialogResult.Yes))
                {
                    paciente.Borrar();
                    this.CargarTabla();
                }
            }
        }
    }
}
