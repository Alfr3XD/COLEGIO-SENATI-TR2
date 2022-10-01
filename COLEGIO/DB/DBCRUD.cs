using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COLEGIO.DATA;

namespace COLEGIO.DB
{
    class DBCRUD: DatabaseConnection
    {
        SqlDataReader ReadFiles;
        SqlCommand Command = new SqlCommand();

        public List<ALUMNO> GetLog(string filter)
        {
            Command.Connection = Connection;
            Command.CommandText = "sp_alumno_log";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@wheres", filter);

            Connection.Open();
            ReadFiles = Command.ExecuteReader();
            List<ALUMNO> ListaGenerica = new List<ALUMNO>();

            while (ReadFiles.Read())
            {
                ListaGenerica.Add(new ALUMNO
                {
                    ID = ReadFiles.GetInt32(0),
                    DNI = ReadFiles.GetString(1),
                    NOMBRES  = ReadFiles.GetString(2),
                    APELLIDO_PATERNO = ReadFiles.GetString(3),
                    APELLIDO_MATERNO = ReadFiles.GetString(4),
                    TELEFONO  = ReadFiles[5].ToString(),
                    CELULAR = ReadFiles[6].ToString(),
                    DIRECCION = ReadFiles[7].ToString(),
                    CORREO = ReadFiles[8].ToString(),
                    NACIMIENTO = ReadFiles.GetDateTime(9).ToString()
                });
            }
            ReadFiles.Close();
            Connection.Close();
            return ListaGenerica;
        }

        public void AddAlumno(ALUMNO DATA)
        {
            Connection.Open();
            SqlCommand CommandSet = new SqlCommand(
                "INSERT INTO ALUMNO values (@id, @dni, @name, @p_ap, @m_ap, @te, @ce, @ad, @em, @na)",
                Connection);
            CommandSet.Parameters.AddWithValue("@id", DATA.ID);
            CommandSet.Parameters.AddWithValue("@dni", DATA.DNI);
            CommandSet.Parameters.AddWithValue("@name", DATA.NOMBRES);
            CommandSet.Parameters.AddWithValue("@p_ap", DATA.APELLIDO_PATERNO);
            CommandSet.Parameters.AddWithValue("@m_ap", DATA.APELLIDO_MATERNO);
            CommandSet.Parameters.AddWithValue("@te", ((object)DATA.TELEFONO ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@ce", ((object)DATA.CELULAR ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@ad", ((object)DATA.DIRECCION ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@em", ((object)DATA.CORREO ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@na", DATA.NACIMIENTO);

            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(CommandSet);
            DA.Fill(DT);
            Connection.Close();
        }

        public void UpdateAlumno(ALUMNO DATA)
        {
            Connection.Open();
            SqlCommand CommandSet = new SqlCommand(
                "UPDATE ALUMNO SET [name] = @name, p_apellido = @p_ap, m_apellido = @m_ap, telefono = @te, celular = @ce, [address] = @ad, email = @em, nacimiento = @na WHERE id = @id or dni = @dni"
                ,Connection);
            CommandSet.Parameters.AddWithValue("@id", DATA.ID);
            CommandSet.Parameters.AddWithValue("@dni", DATA.DNI);
            CommandSet.Parameters.AddWithValue("@name", DATA.NOMBRES);
            CommandSet.Parameters.AddWithValue("@p_ap", DATA.APELLIDO_PATERNO);
            CommandSet.Parameters.AddWithValue("@m_ap", DATA.APELLIDO_MATERNO);
            CommandSet.Parameters.AddWithValue("@te", ((object)DATA.TELEFONO ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@ce", ((object)DATA.CELULAR ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@ad", ((object)DATA.DIRECCION ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@em", ((object)DATA.CORREO ?? DBNull.Value));
            CommandSet.Parameters.AddWithValue("@na", DATA.NACIMIENTO);

            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(CommandSet);
            DA.Fill(DT);
            Connection.Close();
        }

        public void DeleteAlumno(int ID, string DNI)
        {
            Connection.Open();
            SqlCommand CommandSet = new SqlCommand(
                "DELETE ALUMNO WHERE id = @id or dni = @dni"
                , Connection);
            CommandSet.Parameters.AddWithValue("@id", ID);
            CommandSet.Parameters.AddWithValue("@dni", DNI);

            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(CommandSet);
            DA.Fill(DT);
            Connection.Close();
        }
    }
}
