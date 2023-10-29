using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    // Departman bolumu 
    public class EntityDepartman
    {
        private int id;
        private string name;
        private string aciklama;
        
        // getter setter 
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }


    }

}
