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
    public partial class Frm_lista_Funcionarios : Form
    {
        public Frm_lista_Funcionarios()
        {
            InitializeComponent();
        }

        private void Frm_lista_Funcionarios_Load(object sender, EventArgs e)
        {
            this.CargaTabla();
        }
        private void CargaTabla()
        {
            Dgv_funcionarios.Rows.Clear();
            foreach(Funcionario add in Funcionario.Obtenerdatos())
            {
                String[] fila = new String[]
                {
                    Convert.ToString(add.id), add.Correo, add.Nomnbre, add.Apellido, add.Sexo.descripcion, add.Rol
                };
                Dgv_funcionarios.Rows.Add(fila);
            }
        }

        private void Dgv_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                int idfuncionario = Convert.ToInt32(Dgv_funcionarios[0, e.RowIndex].Value);
                Funcionario funcionario = Utilitarios.Lista_funcionario[idfuncionario];

            if(e.ColumnIndex == 6)
            {
                frm_funcionarios formfuncionario = new frm_funcionarios();
                formfuncionario.setFuncionario(funcionario);
                formfuncionario.ShowDialog();
                this.CargaTabla();

            }else if(e.ColumnIndex == 7)
            {
                DialogResult fun = MessageBox.Show("¿ Estas seguro de borrar al funcionario: "+funcionario.Nomnbre +"?", "Eliminar Funcionario",MessageBoxButtons.YesNo);
                if (fun.Equals(DialogResult.Yes))
                {
                    funcionario.Borrar();
                    this.CargaTabla();
                }
            }
        }

       
    }
}
