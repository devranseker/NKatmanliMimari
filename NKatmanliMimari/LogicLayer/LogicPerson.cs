using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace LogicLayer
{
    public class LogicPerson
    {
        public static List<EntityPerson> LLPersonListesi()
        {
            return DALPerson.PersonelListesi();

        }
        public static int LLPersonEkle(EntityPerson p)
        {
            if (p.Name != "" && p.Surname != "" && p.Salary >= 15000)
            {
                return DALPerson.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        // sil methodu 
        public static bool LLPersonelSil(int per)
        {
            if(per >= 1)
            {
                return DALPerson.PersonelSil(per);
            }
            else
            {
                return false;

            }
        }

       public static bool LLPersonGuncelle(EntityPerson ent)
        {
            if(ent.Name.Length >= 2 && ent.Name != "" && ent.Salary >= 1500)
            {
                return DALPerson.PersonelGuncelle(ent);
            }
            else
            {  // dogru degilse dondurme 
                return false;
            }
        }
    } 

   
}
