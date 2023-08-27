using System.ComponentModel.DataAnnotations;

namespace CideTarımKooperatif.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık girilmeli")]
        public string ServiceTitle { get; set; }

        [Display(Name = "Servis görseli")]
        [Required(ErrorMessage = "Servis görseli girilmeli")]
        public string ServiceImage { get; set; }

        [Display(Name = "Servis açıklaması")]
        [Required(ErrorMessage = "Servis açıklaması girilmeli")]
        public string ServiceDescription { get; set; }
    }
}
