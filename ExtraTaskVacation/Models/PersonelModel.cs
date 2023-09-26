using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace VacationTaskUppgift.Models
{
    public partial class PersonelModel : IdentityUser
    {


        [MaxLength(50)]
        [Required]
        [DisplayName("Hela namnet")]
        public string FullName { get; set; } = null!;
        [MaxLength(50)]
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public bool IsAdmin { get; set; }

        [ForeignKey("ActiveVacation")]
        public int FK_ActiveVacationId { get; set; }
        public virtual ICollection<RequestVacationModel>? RequestVacations { get; set; }
    }
}
