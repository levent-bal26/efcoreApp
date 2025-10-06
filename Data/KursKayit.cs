using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace efcore.Data
{

    public class KursKayit
    {

       
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }
        

        public int KursId {get;set;}

        public DateTime KayitTarihi { get; set; }

    }

}