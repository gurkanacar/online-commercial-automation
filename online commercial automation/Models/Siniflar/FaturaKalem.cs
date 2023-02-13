using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace online_commercial_automation.Models.Siniflar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }

        //Iliskiler Kurulum
        //fatura ile faturakalem arasinda
        //bir faturada   1 den fazla fatura kalem girdisi vardir.
        public int Faturaid { get; set; }
        public virtual Faturalar Faturalar { get; set; }
    }
}