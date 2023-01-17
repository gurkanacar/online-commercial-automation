using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace online_commercial_automation.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAD { get; set; }

        //Iliskiler Kurulum
        //Kategori ile urun arasinda
        //Her kategorinin icerisinde 1 den fazla urun vardir.
        public ICollection<Urun> Uruns { get; set; }
    }
}