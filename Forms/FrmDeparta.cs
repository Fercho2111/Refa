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

namespace LinxAdmo.Forms
{
    public partial class FrmDeparta : Form
    {
        
        public FrmDeparta()
        {
            InitializeComponent();
        }

        private void Actualiza_DataDep()
        {
            using (SqlConnection conexion = new SqlConnection(SqlConexion.CadenaConexion))
            {
                conexion.Open();
                SqlCommand Comando = new SqlCommand("SELECT * FROM DEPARTAMENTOS", conexion);
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Comando;
                DataTable Tabla = new DataTable();
                Adaptador.Fill(Tabla);
                datagridDepa.DataSource = Tabla;
            }       
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (SqlConnection conexion=new SqlConnection(SqlConexion.CadenaConexion))
            {
                conexion.Open();
                try
                {
                    int IdDepartamento = Convert.ToInt32(txtIdDepartamento.Text);
                    string Nombre = txtNombre.Text;

                    string consulta = "INSERT INTO Departamentos(IdDeparta,NOmbreDep) VALUES ('" + IdDepartamento + "','" + Nombre + "')";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Departamento guardado correctamente");
                    conexion.Close();
                    txtNombre.Clear();
                    txtIdDepartamento.Clear();
                    Actualiza_DataDep();
                    conexion.Close();
                }
                catch (Exception l)
                {
                    MessageBox.Show("El Departamento no fue registrado correctamente" + l);
                    conexion.Close();
                }
            }
        }

        private void smDeparta_Load(object sender, EventArgs e)
        {
            Actualiza_DataDep();
        }
    }
}
