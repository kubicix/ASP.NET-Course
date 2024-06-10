using System.ComponentModel.DataAnnotations;

namespace EFCoreApp.Data
{
	public class KursKayit
	{
		[Key]
        public int KayitId { get; set; }
        public int OgrenciId { get; set; }
        public int KursId { get; set; }
        public DateTime KayitTarihi { get; set; }

        // 1 ==> 5 , 8 , 10.06.2024 10:00 şeklinde olacaktır.
    }
}
