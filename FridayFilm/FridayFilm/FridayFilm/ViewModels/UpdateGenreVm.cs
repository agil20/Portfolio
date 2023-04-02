using System.ComponentModel.DataAnnotations;

namespace FridayFilm.ViewModels
{
    public class UpdateGenreVm
    {
        [Required(ErrorMessage = "This field can not be empty.")]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
