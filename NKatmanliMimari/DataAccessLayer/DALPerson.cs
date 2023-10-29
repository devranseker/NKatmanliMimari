using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;   // eklemem gerekiyor 
using System.Data.SqlClient;
using System.Data;




namespace DataAccessLayer
{
    public class DALPerson
    {
        // PersonelListesi();
        public static List<EntityPerson> PersonelListesi()
        {

            List<EntityPerson> degerler = new List<EntityPerson>();
            SqlCommand komut1 = new SqlCommand("Select * From TBLINFORMATION ", Connection.baglanti);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();   // baglantı acık değilse ac 
            }
            SqlDataReader veriOku = komut1.ExecuteReader();
            while (veriOku.Read())
            {
                // Person Bilgileri degerlere atacagız 
                EntityPerson entPerson = new EntityPerson();
                entPerson.Id = int.Parse(veriOku["ID"].ToString());
                entPerson.Name = veriOku["NAME"].ToString();
                entPerson.Surname = veriOku["SURNAME"].ToString();
                entPerson.City = veriOku["CITY"].ToString();
                entPerson.Mission = veriOku["MISSION"].ToString();
                entPerson.Salary = short.Parse(veriOku["SALARY"].ToString());
                // entPerson nesnesinden gelen  veri degerlere atayalım  
                degerler.Add(entPerson);
            }
            veriOku.Close();
            return degerler;     // degerleri dondur 
        }

        // Person Ekle 
        public static int PersonelEkle(EntityPerson p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLINFORMATION (NAME, SURNAME, CITY, MISSION, SALARY) VALUES (@P1,@P2,@P3,@P4,@P5)", Connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();   // baglantı acık değilse ac 
            }
            // Parametre atamaları 
            komut2.Parameters.AddWithValue("@P1", p.Name);
            komut2.Parameters.AddWithValue("@P2", p.Surname);
            komut2.Parameters.AddWithValue("@P3", p.City);
            komut2.Parameters.AddWithValue("@P4", p.Mission);
            komut2.Parameters.AddWithValue("@P5", p.Salary);
            // VE BU DEGERLERI DONDURSUN 
            return komut2.ExecuteNonQuery();

        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBLINFORMATION where ID = @P1", Connection.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            // yukarıdaki sartlarlı saglayan varsa buyuktur sıfır cunku veritibi boolean 
            return komut3.ExecuteNonQuery() > 0;
        }
        // Person Update 
        public static bool PersonelGuncelle(EntityPerson ent)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLINFORMATION SET NAME = @P1,SURNAME = @P2, CITY = @P3, MISSION = @P4, SALARY = @P5 WHERE ID = @P6", Connection.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            // PArametre atamaları
            komut4.Parameters.AddWithValue("@P1", ent.Name);
            komut4.Parameters.AddWithValue("@P2", ent.Surname);
            komut4.Parameters.AddWithValue("@P3", ent.City);
            komut4.Parameters.AddWithValue("@P4", ent.Mission);
            komut4.Parameters.AddWithValue("@P5", ent.Salary);
            komut4.Parameters.AddWithValue("@P6", ent.Id);
            return komut4.ExecuteNonQuery() > 0;
      
        }


    }
}


