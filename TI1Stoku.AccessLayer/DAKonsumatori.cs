using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI1Stoku.EntityLayer;

namespace TI1Stoku.AccessLayer
{
    public class DAKonsumatori
    {
        public static List<Konsumatori> GetAll()
        {
            List<Konsumatori> klientat = new List<Konsumatori>();
            var constr = "Data Source=DESKTOP-IAIB3LL;Initial Catalog=TI1;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("selectAllKonsumatort", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Konsumatori klienti = new Konsumatori();

                    klienti.Konsumatori_ID = int.Parse(reader["Konsumatori_ID"].ToString());
                    klienti.Emri = reader["Emri"].ToString();
                    klienti.Mbiemri = reader["Mbiemri"].ToString();
                    klienti.Adresa = reader["Adresa"].ToString();
                    klienti.NumriBiznesor = reader["NumriTelefonit"].ToString();
                    klienti.NumriTelefonit = reader["NumriBiznesor"].ToString();

                    klientat.Add(klienti);
                }

                if (klientat != null)
                    return klientat;
                else
                    return null;
            }
        }

        public static void Insert(string Emri, string Mbiemri, string Adresa, string NumriBiznesor, string NumriTelefonit)
        {

            var constr = "Data Source=DESKTOP-IAIB3LL;Initial Catalog=TI1;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("InsertKonsumatori", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Emri", SqlDbType.NVarChar).Value = Emri;
                cmd.Parameters.Add("@Mbiemri", SqlDbType.NVarChar).Value = Mbiemri;
                cmd.Parameters.Add("@Adresa", SqlDbType.NVarChar).Value = Adresa;
                cmd.Parameters.Add("@NumriTelefonit", SqlDbType.NVarChar).Value = NumriTelefonit;
                cmd.Parameters.Add("@NumriBiznesor", SqlDbType.NVarChar).Value = NumriBiznesor;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        public static void Update(int id, string Emri, string Mbiemri, string Adresa, string NumriBiznesor, string NumriTelefonit)
        {

            var constr = "Data Source=DESKTOP-IAIB3LL;Initial Catalog=TI1;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("UpdateKonsumatori", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Emri", SqlDbType.NVarChar).Value = Emri;
                cmd.Parameters.Add("@Mbiemri", SqlDbType.NVarChar).Value = Mbiemri;
                cmd.Parameters.Add("@Adresa", SqlDbType.NVarChar).Value = Adresa;
                cmd.Parameters.Add("@NumriTelefonit", SqlDbType.NVarChar).Value = NumriTelefonit;
                cmd.Parameters.Add("@NumriBiznesor", SqlDbType.NVarChar).Value = NumriBiznesor;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void DeleteById(int id)
        {

            var constr = "Data Source=DESKTOP-IAIB3LL;Initial Catalog=TI1;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("DeleteKonsumatoriById", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
