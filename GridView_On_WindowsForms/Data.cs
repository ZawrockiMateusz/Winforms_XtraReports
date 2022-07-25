using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView_On_WindowsForms
{
    public class Data
    {
        private int id;
        private int numer_zamowienia;
        private string opis;
        private string nazwa_klienta;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
        public int Numer_Zamowienia
        {
            get { return this.numer_zamowienia; }
            set { this.numer_zamowienia = value; }
        }
        
        public string Opis
        {
            get { return this.opis; }
            set { this.opis = value; }
        }
        
        public string Nazwa_Klienta
        {
            get { return this.nazwa_klienta; }
            set { this.nazwa_klienta = value; }
        }



        /*private List<int> id_Data = new List<int>();
        private List<int> numer_zamowienia_Data = new List<int>();
        private List<string> opis_Data = new List<string>();
        private List<string> nazwa_klienta_Data = new List<string>();

        public List<int> Id_Data
        {
            get { return id_Data; }
            set { id_Data = value; }
        }
        public List<int> Numer_Zamowienia_Data
        {
            get { return numer_zamowienia_Data; }
            set { numer_zamowienia_Data = value; }
        }
        public List<string> Opis_Data
        {
            get { return opis_Data; }
            set { opis_Data = value; }
        }
        public List<string> Nazwa_Klienta_Data
        {
            get { return nazwa_klienta_Data; }
            set { nazwa_klienta_Data = value; }
        }*/
        public Data()
        {

        }

    }
}
