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
    public partial class frm_listade_doctores : Form
    {
        public frm_listade_doctores()
        {
            InitializeComponent();
        }


        private void frm_listade_especialidades_Load(object sender, EventArgs e)
        {
            this.Cargatabla();
        }
        private void Cargatabla()
        {
            dgv_especialidades.Rows.Clear();
            foreach (Doctor espe in Doctor.ObtenerDatosdoctor())
            {
                String[] fila = new String[]
                {
                    Convert.ToString(espe.id), espe.Especialidad.descripcion,espe.Nombre,espe.Apellido,espe.Documento,espe.Sexo.descripcion,espe.Telefono,espe.Ruc
                };
                dgv_especialidades.Rows.Add(fila);
            }
        }

        private void dgv_especialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int iddoctor = Convert.ToInt32(dgv_especialidades[0, e.RowIndex].Value);//El “row” indica la fila. Indicamos el nombre de la columna “Numero” del cual obtenemos la información. Transformamos el dato obtenido en una cadena
                Doctor doctor = Utilitarios.Lista_doctor[iddoctor];                //Los indexers son una propiedad que nos permite trabajar con un objeto como si fuera un array . Cuando definimos un indexer para una clase, esa clase actuará como un array virtual. Recuerda que para acceder a los elementos de un array lo hacemos con [index] .

            if (e.ColumnIndex == 8)
            {
                
                frm_doctores formdoctor = new frm_doctores();
                formdoctor.setDoctor(doctor);
                formdoctor.ShowDialog();
                this.Cargatabla();
            }else if(e.ColumnIndex == 9)
            {
                DialogResult dr = MessageBox.Show(" ¿ Estas seguro de borrar al doctor: "+doctor.Nombre+" ?"," Eliminar Doctor ", MessageBoxButtons.YesNo);
                if (dr.Equals(DialogResult.Yes))
                {
                    doctor.Borrar();
                    this.Cargatabla();
                }
            }
        }
    }

}

