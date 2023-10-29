using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;


namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Listele Butonu 
        private void BtnList_Click(object sender, EventArgs e)
        {
            //EntityPerson'e git ve Personel Listesinde  PrsnListele adında bir tane deger olustur 
            // olusturdugumuz degiskenin icinde deger atalım  LogicPerson.LLPersonListesi();                                                 
            List<EntityPerson> PrsnListele = LogicPerson.LLPersonListesi();
            dataGridView1.DataSource = PrsnListele;
        }

        // Ekleme Butonu 
        private void BtnEkle_Click(object sender, EventArgs e)
        {      // EntityPerson classına nesne yardımı ile ulastım 
            EntityPerson etnPrsn = new EntityPerson();
            etnPrsn.Name = TxtName.Text;
            etnPrsn.Surname = TxtSurname.Text;
            etnPrsn.City = TxtCity.Text;
            etnPrsn.Salary = short.Parse(TxtSalary.Text);
            etnPrsn.Mission = TxtMission.Text;

            LogicPerson.LLPersonEkle(etnPrsn);
        }

        // Silme Butonu 
        private void BtnSil_Click(object sender, EventArgs e)
        {    // EntityPerson clasına ulastım 
            EntityPerson enttyPrsn = new EntityPerson();
            enttyPrsn.Id = Convert.ToInt32(TxtID.Text);
            //LogicPerson icindeki LLPersonelSil methodu ile  EntityPerson clasindan gelen Id'yi sil 
            LogicPerson.LLPersonelSil(enttyPrsn.Id);
        }

        // Guncelle Butonu 
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPerson ent = new EntityPerson();
            ent.Id = Convert.ToInt32(TxtID.Text);
            ent.Name = TxtName.Text;
            ent.Surname = TxtSurname.Text;
            ent.City = TxtCity.Text;
            ent.Mission = TxtMission.Text;
            ent.Salary = short.Parse(TxtSalary.Text);
            // Yukaridakileri guncelle 
            LogicPerson.LLPersonGuncelle(ent);

        }

       
    }
}
