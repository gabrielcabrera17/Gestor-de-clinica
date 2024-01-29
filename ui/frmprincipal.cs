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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            this.Text = " Consultorio medico cyt 2022 - Gabriel Cabrera";
            //Size = new Size(1000,900);
            Genero Masculino = new Genero(1, "Masculino");
            Masculino.Guardar();
            Genero Femenino = new Genero(2, "Femenino");
            Femenino.Guardar();
            Genero Nuevogenero = new Genero(3, "Nuevo Genero");
            Nuevogenero.Guardar();
            Especialidad Ginecologo = new Especialidad(3, "Ginecologo");
            Ginecologo.Guardar();
            Especialidad Cardiologo = new Especialidad(4, "Cardiologo");
            Cardiologo.Guardar();
            Especialidad Clinico = new Especialidad(5, "Clinico");
            Clinico.Guardar();
            //Genero
            Genero[] sexo = new Genero[2];
            sexo[0] = Femenino;
            sexo[1] = Masculino;
            //sexo[2] = Nuevogenero;
            //Especialidades
            Especialidad[] especialidades = new Especialidad[2];
            especialidades[0] = Ginecologo;
            especialidades[1] = Cardiologo;
           // especialidades[2] = Clinico;

            Paciente[] pacientes = new Paciente[5];
            Doctor[] doctores = new Doctor[5];
            Funcionario[] funcionarios = new Funcionario[5];
           
            for (int i = 0; i <= 5; i++)
            {
                Paciente pac = new Paciente();

                Doctor doc = new Doctor();

                Funcionario fun = new Funcionario();
              
                pac.id = i;
                pac.Nombre = "Juana"+i;
                pac.Apellido = "Aguilar"+i;
                pac.Documento = "5510"+i;
                pac.Fecha = DateTime.Now;
                pac.Sexo = sexo[0];
                pacientes[1] = pac;
                pac.Guardar();
                //Doctores
                doc.id = i;
                doc.Nombre = "Pedro"+ 1;
                doc.Apellido = "Rivarola"+ i;
                doc.Telefono = "0214512"+ i;
                doc.Documento = "14520"+ 1;
                doc.Ruc = "4545-78";
                doc.Sexo = sexo[1];
                doc.Especialidad = especialidades[1];
                doctores[1] = doc;
                doc.Guardar();
                //Funcionario
                fun.id = i;
                fun.Nomnbre = "Roberta" + i;
                fun.Correo = "Sasa@hotmail.com" + i;
                fun.Apellido = "Medina"+i;
                fun.Rol = "Farmaceutico" + i;
                fun.Sexo = sexo[0];
                funcionarios[1] = fun;
                fun.Guardar();

            }
           
        }

        

       

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_funcionarios consultarfun = new frm_funcionarios();
            consultarfun.setFuncionario(new Funcionario());
            consultarfun.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultaPaciente consul = new frm_ConsultaPaciente();
            consul.setPaciente(new Paciente());
            consul.ShowDialog();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_listade_doctores mostrar = new frm_listade_doctores();
            mostrar.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_de_pacientes mostrar = new frm_lista_de_pacientes();
            mostrar.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e) // doctor
        {
            frm_doctores mostrar = new frm_doctores();
            mostrar.setDoctor(new Doctor());
            mostrar.ShowDialog();
        }

        private void listaFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_lista_Funcionarios mostrar = new Frm_lista_Funcionarios();
            mostrar.Show();
        }

       
    }
}
