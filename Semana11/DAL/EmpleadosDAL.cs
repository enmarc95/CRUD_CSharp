using Semana11.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11.DAL
{
    public class EmpleadosDAL
    {
        private Database db;
        public EmpleadosDAL()
        {
            db = new Database();
        }

        public DataTable getAllEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createEmpleado(EmpleadosBLL emp, SedesBLL sede, CargosBLL cargo)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, telefono, id_sede, dui, id_cargo) VALUES (@nom, @ap, @em, @tel, @idS, @dui, @idC);";
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@em", emp.Email);
                    cmd.Parameters.AddWithValue("@tel", emp.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id);
                    cmd.Parameters.AddWithValue("@dui", emp.Dui);
                    cmd.Parameters.AddWithValue("@idC", cargo.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }
        
        public bool updateEmpleado(EmpleadosBLL emp, SedesBLL sede, CargosBLL cargo)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Empleados SET nombres = @nom, apellidos = @ap, email = @em, telefono = @tel, id_sede = @idS, dui = @dui, id_cargo = @idC WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@em", emp.Email);
                    cmd.Parameters.AddWithValue("@tel", emp.Telefono);
                    cmd.Parameters.AddWithValue("@idS", sede.Id);
                    cmd.Parameters.AddWithValue("@dui", emp.Dui);
                    cmd.Parameters.AddWithValue("@idC", cargo.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteEmpleado(EmpleadosBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
