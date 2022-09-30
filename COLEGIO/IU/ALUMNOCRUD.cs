using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COLEGIO.DB;
using COLEGIO.DATA;

namespace COLEGIO.IU
{
    public partial class ALUMNOCRUD : Form
    {
        public ALUMNOCRUD()
        {
            InitializeComponent();
        }

        private void ALUMNOCRUD_Load(object sender, EventArgs e)
        {
            DBCRUD alum = new DBCRUD();
            DATAGRID.DataSource = alum.GetLog("");
        }

        private void Label2_Click(object sender, EventArgs e){}
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e){}
        private void DATAGRID_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void SEARCH_BTN_Click(object sender, EventArgs e)
        {
            DBCRUD alum = new DBCRUD();
            DATAGRID.DataSource = alum.GetLog(SEARCH_TXT.Text);
        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {

            DBCRUD alum = new DBCRUD();

            List<ALUMNO> Alumnos = alum.GetLog("");

            if(Convert.ToInt32(NUMERIC.Value) < 1)
            {
                MessageBox.Show("Debes ingresar una ID mayor a 0.");
                return;
            }

            if (string.IsNullOrEmpty(DNI_TEXT.Text))
            {
                MessageBox.Show("No ingresó el dni del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(NAME_TEXT.Text))
            {
                MessageBox.Show("No ingresó los nombres del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(P_APELLIDO_TEXT.Text))
            {
                MessageBox.Show("No ingresó el apellido paterno del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(M_APELLIDO_TEXT.Text))
            {
                MessageBox.Show("No ingresó el apellido materno del alumno.");
                return;
            }

            foreach(ALUMNO Alumno in Alumnos)
            {
                if(Alumno.ID == Convert.ToInt32(NUMERIC.Value))
                {
                    MessageBox.Show("Ya hay un alumno con esta ID");
                    return;
                }
                if(Alumno.DNI == DNI_TEXT.Text)
                {
                    MessageBox.Show("Ya hay un alumno con este DNI");
                    return;
                }
            }

            ALUMNO NewAlumno = new ALUMNO
            {
                ID = Convert.ToInt32(NUMERIC.Value),
                DNI = DNI_TEXT.Text,
                NOMBRES = NAME_TEXT.Text,
                APELLIDO_PATERNO = P_APELLIDO_TEXT.Text,
                APELLIDO_MATERNO = M_APELLIDO_TEXT.Text,
                TELEFONO = TELEFONO_TEXT.Text,
                CELULAR = CELULAR_TEXT.Text,
                DIRECCION = DIRECCION_TEXT.Text,
                CORREO = CORREO_TEXT.Text,
                NACIMIENTO = FECHA.Value.ToString("dd-MM-yyyy"),
                OBSERVACIONES = Convert.ToInt32(NUMERIC.Value)
            };

            alum.AddAlumno(NewAlumno);

            MessageBox.Show("Se añadió al alumno:" + 
                "\nNOMBRE COMPLETO: " + NewAlumno.NOMBRES + NewAlumno.APELLIDO_PATERNO + NewAlumno.APELLIDO_MATERNO + 
                "\nDNI: " + NewAlumno.DNI + "\nID:" + NewAlumno.ID
                );
        }

        private void UPDATE_BTN_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(NUMERIC.Value) < 1)
            {
                MessageBox.Show("Debes ingresar una ID mayor a 0.");
                return;
            }

            if (string.IsNullOrEmpty(DNI_TEXT.Text))
            {
                MessageBox.Show("No ingresó el dni del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(NAME_TEXT.Text))
            {
                MessageBox.Show("No ingresó los nombres del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(P_APELLIDO_TEXT.Text))
            {
                MessageBox.Show("No ingresó el apellido paterno del alumno.");
                return;
            }

            if (string.IsNullOrEmpty(M_APELLIDO_TEXT.Text))
            {
                MessageBox.Show("No ingresó el apellido materno del alumno.");
                return;
            }

            DBCRUD alum = new DBCRUD();

            List<ALUMNO> Alumnos = alum.GetLog("");
            if(Alumnos.Count < 1)
            {
                MessageBox.Show("No hay Alumnos para actualizar.");
                return;
            }
            foreach (ALUMNO Alumno in Alumnos)
            {
                if (Alumno.ID == Convert.ToInt32(NUMERIC.Value))
                {
                    ALUMNO NewAlumno = new ALUMNO
                    {
                        ID = Convert.ToInt32(NUMERIC.Value),
                        DNI = DNI_TEXT.Text,
                        NOMBRES = NAME_TEXT.Text,
                        APELLIDO_PATERNO = P_APELLIDO_TEXT.Text,
                        APELLIDO_MATERNO = M_APELLIDO_TEXT.Text,
                        TELEFONO = TELEFONO_TEXT.Text,
                        CELULAR = CELULAR_TEXT.Text,
                        DIRECCION = DIRECCION_TEXT.Text,
                        CORREO = CORREO_TEXT.Text,
                        NACIMIENTO = FECHA.Value.ToString("dd-MM-yyyy"),
                        OBSERVACIONES = Convert.ToInt32(NUMERIC.Value)
                    };

                    alum.UpdateAlumno(NewAlumno);

                    MessageBox.Show("Los datos de alumno fueron actualizados."); 
                    return;
                }    
            }
            MessageBox.Show("La ID del usuario no fue encontrada.");
        }

        private void REFRESH_BTN_Click(object sender, EventArgs e)
        {
            DBCRUD alum = new DBCRUD();
            DATAGRID.DataSource = alum.GetLog("");
        }

        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(NUMERIC.Value) < 1)
            {
                MessageBox.Show("Debes ingresar una ID mayor a 0.");
                return;
            }

            if (string.IsNullOrEmpty(DNI_TEXT.Text))
            {
                MessageBox.Show("No ingresó el dni del alumno.");
                return;
            }

            DBCRUD alum = new DBCRUD();

            List<ALUMNO> Alumnos = alum.GetLog("");
            if (Alumnos.Count < 1)
            {
                MessageBox.Show("No hay Alumnos para eliminar.");
                return;
            }
            foreach (ALUMNO Alumno in Alumnos)
            {
                if (Alumno.ID != Convert.ToInt32(NUMERIC.Value) || Alumno.DNI != DNI_TEXT.Text)
                {
                    MessageBox.Show("El DNI o La ID no fueron encontradas");
                    return;
                }
            }

            alum.DeleteAlumno(Convert.ToInt32(NUMERIC.Value), DNI_TEXT.Text);

            MessageBox.Show("Se eliminó al alumno con la ID: " + NUMERIC.Value.ToString());
        }

        private void SEARCH_1_BTN_Click(object sender, EventArgs e)
        {
            DBCRUD alum = new DBCRUD();
            List<ALUMNO> Alumnos = alum.GetLog("");
            if (Alumnos.Count < 1)
            {
                MessageBox.Show("No hay Alumnos para buscar.");
                return;
            }
            foreach (ALUMNO Alumno in Alumnos)
            {
                if (Alumno.ID == Convert.ToInt32(NUMERIC.Value) || Alumno.DNI == DNI_TEXT.Text)
                {
                    DateTime oDate = DateTime.ParseExact(Alumno.NACIMIENTO, "dd/MM/yyyy HH:mm:ss", null);
                    NUMERIC.Value = Alumno.ID;
                    DNI_TEXT.Text = Alumno.DNI;
                    NAME_TEXT.Text = Alumno.NOMBRES;
                    P_APELLIDO_TEXT.Text = Alumno.APELLIDO_PATERNO;
                    M_APELLIDO_TEXT.Text = Alumno.APELLIDO_MATERNO;
                    TELEFONO_TEXT.Text = Alumno.TELEFONO;
                    CELULAR_TEXT.Text = Alumno.CELULAR;
                    DIRECCION_TEXT.Text = Alumno.DIRECCION;
                    CORREO_TEXT.Text = Alumno.CORREO;
                    FECHA.Value = oDate;
                    return;
                }
            }
            MessageBox.Show("Alumno no encontrado.");
        }
    }
}
