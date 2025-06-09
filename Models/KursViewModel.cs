
using System.ComponentModel.DataAnnotations;
using EFCoreApp.Data;

namespace EFCoreApp.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required]
        [Display(Name = "Kurs Başlığı")]
        public string? Baslik { get; set; }
        public int OgretmenId { get; set; }

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

    }
}