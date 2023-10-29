using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //  EntityPerson == Personel varlik kümesi 
    public class EntityPerson
    {   // daha once entityde hazır class geliyordu simdi ise capsulleme ile yapacagız 
        // degiskenlerimiz  /mission == görev
        private int id;
        private string name;
        private string surname;
        private string city;
        private string mission;
        private short salary;  
        // Sql'de smallint == C#'daki short'a
        //  simdi bu degiskenleri class uzerinden erisim saglayıp diger katmanlar uzerinden cagırma islemini gerceklestiremem 
       // Ben bu degiskenlerin proportiy yapilarina erisim saglarım 
       // simdi proporti olusturalim  == ctrl and r'ye basili tutun sonra e'ye basılı tutun 
        
        // Capsulleme
        public int Id { get => id; set => id = value; }  // bu her bir yapinin ismi propertiy 
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public string Mission { get => mission; set => mission = value; }
        public short Salary { get => salary; set => salary = value; }
    }

}
