using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Data;
namespace pryPonceIEFI
{
    internal class Club
    {

        OleDbConnection cobasedato = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb");
        OleDbCommand commandbasedato= new OleDbCommand();
        OleDbDataReader readerbasedato;


        public void cargarPais(string nombrePais)
        {
            cobasedato.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb";

            commandbasedato.Connection = cobasedato;
            commandbasedato.CommandType = CommandType.Text;
            commandbasedato.CommandText = "SELECT NOMBRE_PAIS FROM PAISES WHERE NOMBRE_PAIS = ?";
            commandbasedato.Parameters.AddWithValue("@Pais", nombrePais);

            commandbasedato.Connection.Open();
            readerbasedato = commandbasedato.ExecuteReader();

            if (readerbasedato.HasRows)
            {
                MessageBox.Show("el pais ya existe");
                commandbasedato.Connection.Close();
                return;
            }

            MessageBox.Show("el pais fue agregado exitosamente");
            readerbasedato.Close();

            commandbasedato.CommandText = "INSERT INTO PAISES (NOMBRE_PAIS) VALUES (?)";
            commandbasedato.Parameters.AddWithValue("@Pais", nombrePais.Trim());

            commandbasedato.ExecuteNonQuery();
            commandbasedato.Connection.Close();
        }

        public void cargarCombo(ComboBox cmbPaises)
        {
            cmbPaises.Items.Clear();
            commandbasedato.Connection = cobasedato;
            commandbasedato.CommandType = CommandType.TableDirect;
            commandbasedato.CommandText = "PAISES";
            commandbasedato.Connection.Open();
            readerbasedato = commandbasedato.ExecuteReader();

            while (readerbasedato.Read())
            {
                cmbPaises.Items.Add(readerbasedato[1]);
            }

            commandbasedato.Connection.Close();
        }

        public void agregarSocio(string nombre, string apellido, string pais, int edad, bool sexo, decimal importe, int puntaje)
        {
            try
            {
                cobasedato.Open();

                OleDbCommand commandInsert = new OleDbCommand();
                commandInsert.Connection = cobasedato;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO, PUNTAJE) VALUES (?, ?, ?, ?, ?, ?, ?)";
                commandInsert.Parameters.AddWithValue("@Nombre", nombre);
                commandInsert.Parameters.AddWithValue("@Apellido", apellido);
                commandInsert.Parameters.AddWithValue("@Pais", pais);
                commandInsert.Parameters.AddWithValue("@Edad", edad);
                commandInsert.Parameters.AddWithValue("@Sexo", sexo);
                commandInsert.Parameters.AddWithValue("@Importe", importe);
                commandInsert.Parameters.AddWithValue("@Puntaje", puntaje);

                commandInsert.ExecuteNonQuery();

                cobasedato.Close();

                cobasedato.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


    }
}
