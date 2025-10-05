using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{

    public class Ogrenci
    {
        //id => primary key

        [Key]
        public int OgrenciId { get; set; }

        public int? OgrenciAd { get; set; }

        public int? OgrenciSoyad { get; set; }

        public int? EPosta { get; set; }

        public int? Telefon{ get; set; }


    }
}