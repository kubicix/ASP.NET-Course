using System.ComponentModel.DataAnnotations;

namespace EFCoreApp.Data
{
	public class Kurs
	{
		[Key]
        public int KursId { get; set; }
		public string? Baslik { get; set; }
		public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
	}
}
