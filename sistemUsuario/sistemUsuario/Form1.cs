using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace sistemUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=sistema;sslMode=none"
            );
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        string usuarioid;
        int resulta;


        private void loadData()
        {
            try
            {
                sql = "Select ID, Numero_Documento, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Direccion, Edad, Genero from usuarios";
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                txtDocumento.Clear();
                txtPNombre.Clear();
                txtSNombre.Clear();
                txtPApellido.Clear();
                txtSApellido.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtDireccion.Clear();
                txtEdad.Clear();
                txtGenero.Clear();



                btnInsertar.Enabled = true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }

        private void insertarDatos()
        {
            try
            {
                sql = "Insert into usuarios(Numero_Documento, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Direccion, Edad, Genero) values ('" + txtDocumento.Text + "','" + txtPNombre.Text + "','" + txtSNombre.Text + "','" + txtPApellido.Text + "','" + txtSApellido.Text + "','" + txtTelefono.Text + "','" + txtCorreo.Text + "','" + txtDireccion.Text + "','" + txtEdad.Text + "','" + txtGenero.Text + "')";
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                resulta = cmd.ExecuteNonQuery();

                if (resulta > 0)
                {
                    MessageBox.Show("El dato ha sido insertado con éxito !!!", "Insertado");
                }
                else
                {
                    MessageBox.Show("Falló la Ejecución :(", "Error");

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            insertarDatos();
            loadData();
        }



        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDocumento_Validated(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDocumento, "Introduce el documento...");
                txtDocumento.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPNombre_Validated(object sender, EventArgs e)
        {
            if (txtPNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPNombre, "Introduce tu primer nombre...");
                txtPNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSNombre_Validated(object sender, EventArgs e)
        {
            if (txtSNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSNombre, "Introduce tu segundo nombre...");
                txtSNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPApellido_Validated(object sender, EventArgs e)
        {
            if (txtPApellido.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPApellido, "Introduce tu primer apellido...");
                txtPApellido.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSApellido_Validated(object sender, EventArgs e)
        {
            if (txtSApellido.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSApellido, "Introduce tu segundo apellido...");
                txtSApellido.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTelefono, "Introduce tu teléfono...");
                txtTelefono.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCorreo, "Introduce tu correo...");
                txtCorreo.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDireccion_Validated(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDireccion, "Introduce tu dirección...");
                txtDireccion.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEdad_Validated(object sender, EventArgs e)
        {
            if (txtEdad.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEdad, "Introduce tu edad...");
                txtEdad.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGenero_Validated(object sender, EventArgs e)
        {
            if (txtGenero.Text.Trim() == "")
            {
                errorProvider1.SetError(txtGenero, "Introduce tu género (Masculino/Femenino)...");
                txtGenero.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("G:\\Datos_Usuarios.txt");
            sw.WriteLine("Numero Documento: " + txtDocumento.Text);
            sw.WriteLine("Primer Nombre: " + txtPNombre.Text);
            sw.WriteLine("Segundo Nombre: " + txtSNombre.Text);
            sw.WriteLine("Primer Apellido: " + txtPApellido.Text);
            sw.WriteLine("Segundo Apellido: " + txtSApellido.Text);
            sw.WriteLine("Teléfono: " + txtTelefono.Text);
            sw.WriteLine("Correo: " + txtCorreo.Text);
            sw.WriteLine("Dirección: " + txtDireccion.Text);
            sw.WriteLine("Edad: " + txtEdad.Text);
            sw.WriteLine("Genero: " + txtGenero.Text);
            sw.Close();

        }
       
    }
}
    
