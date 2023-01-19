using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace online_commercial_automation.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisID { get; set; }
        //Urun
        //cari
        //personel   iliskili tablolardan gelicek
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        //urun cari parsonel iliskiler asagidadir
        public Urun Urun { get; set; }
        public Cariler Carilers { get; set; }
        public personel Personel { get; set; }
    }
}