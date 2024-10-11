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
    public partial class smDeparta : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public smDeparta()
        {
            InitializeComponent();
        }

        private void Actualiza_DataDep()
        {
            SqlCommand Comando = new SqlCommand("SELECT * FROM DEPARTAMENTOS", sqlcon);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = Comando;
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            datagridDepa.DataSource = Tabla;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            sqlcon.Open();

            try
            {
                int IdDepartamento = Convert.ToInt32(txtIdDepartamento.Text);
                string Nombre = txtNombre.Text;
           
                string consulta = "INSERT INTO Departamentos(IdDeparta,NOmbreDep) VALUES ('" + IdDepartamento + "','" + Nombre + "')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                comando.ExecuteNonQuery();
                MessageBox.Show("Departamento guardado correctamente");
                sqlcon.Close();
                txtNombre.Clear();
                txtIdDepartamento.Clear();
                Actualiza_DataDep();
                sqlcon.Close();

            }
            catch (Exception l)
            {
                MessageBox.Show("El Departamento no fue registrado correctamente" + l);
                sqlcon.Close();
            }
        }

        private void smDeparta_Load(object sender, EventArgs e)
        {
            Actualiza_DataDep();
        }
    }
}
