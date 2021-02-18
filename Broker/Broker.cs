using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen; 
namespace DbBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdvokatskaKancelarija;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }
        public int Obrisi(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"DELETE FROM {domenskiObjekat.TableName} where {domenskiObjekat.KriterijumPretrage}";
            return command.ExecuteNonQuery();
        }

        public int Sacuvaj(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"Insert into {domenskiObjekat.TableName} values ({domenskiObjekat.InsertValues})";
            Console.WriteLine(command.CommandText);
            return command.ExecuteNonQuery();
        }

        public List<DomenskiObjekat> VratiSve(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti}  FROM {domenskiObjekat.TableName}";
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.GetEntities(reader);
            reader.Close();
            return rezultat;

        }
        public int VratiMaxID(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT max({domenskiObjekat.TableName}id) FROM {domenskiObjekat.TableName}";
      //      Console.WriteLine(command.CommandText);
     //       MessageBox.Show(command.CommandText);
            object id= command.ExecuteScalar();


            if (id == DBNull.Value)
                return 1;

            else return (int)id;

        }
        public DomenskiObjekat Pronadji(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {domenskiObjekat.TableName} where {domenskiObjekat.KriterijumPretrage}";
            SqlDataReader reader = command.ExecuteReader();
            DomenskiObjekat rezultat = domenskiObjekat.GetEntity(reader);
            reader.Close();
            return rezultat;
        }
        public List<DomenskiObjekat> VratiSveJoinWhere(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.TableName} {domenskiObjekat.JoinFull} where {domenskiObjekat.UslovZaFiltriranje}";
            Console.Write(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.GetEntities(reader);
            reader.Close();
            return rezultat;

        }
        public DomenskiObjekat VratiJedanJoin(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {domenskiObjekat.PovratneVrednosti} FROM {domenskiObjekat.TableName} {domenskiObjekat.JoinFull} where {domenskiObjekat.JoinCondition}";
            Console.Write(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            DomenskiObjekat rezultat = domenskiObjekat.GetEntity(reader);
            reader.Close();
            return rezultat;

        }
        public List<DomenskiObjekat> Filtriraj(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {domenskiObjekat.TableName} where {domenskiObjekat.UslovZaFiltriranje}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = domenskiObjekat.GetEntities(reader);
            reader.Close();
            return rezultat;

        }
    

        public int Azuriraj(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"Update {domenskiObjekat.TableName} set {domenskiObjekat.UpdateValues} where {domenskiObjekat.KriterijumPretrage}";
            Console.WriteLine(command.CommandText);
            int rez = command.ExecuteNonQuery();
            return rez;
        }
        public int Arhiviraj(DomenskiObjekat domenskiObjekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"Update {domenskiObjekat.TableName} set {domenskiObjekat.Arhiviranje} where {domenskiObjekat.KriterijumPretrage}";
            Console.WriteLine(command.CommandText);
            int rez = command.ExecuteNonQuery();
            return rez;
        }
    }
}
