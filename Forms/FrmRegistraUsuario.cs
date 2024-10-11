using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinxAdmo
{
    public partial class SMRegistraUsuario : Form
    {
        public SMRegistraUsuario()
        {
            
            InitializeComponent();
            
        }

        public void limpia()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtContraseña.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                sqlcon.Open();
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Domicilio = txtDomicilio.Text;
                string Telefono = txtTelefono.Text;
                string Usuario = txtUsuario.Text;
                string Contraseña = txtContraseña.Text;
                string TUsuario = txtTUsuario.Text;

                string consulta = "INSERT INTO Usuarios(Nombre,Apellido,Domicilio,Telefono,Usuario,Contra,tUsuario) VALUES ('" + Nombre + "','" + Apellido + "','" + Domicilio + "','" + Telefono + "','" + Usuario + "','" + Contraseña + "','" + TUsuario + "') ";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario guardado correctamente");
                sqlcon.Close();
                limpia();



            }catch(Exception l)
            {
                MessageBox.Show("El usuario no se registro de forma correcta" + l);
            }
            
        }

        private void SMRegistraUsuario_Load(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtContraseña.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
