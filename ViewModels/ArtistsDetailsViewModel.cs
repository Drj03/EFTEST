using EFTest.Models;

namespace EFTest.ViewModels
{
    public class ArtistsDetailsViewModel
    {
        public IEnumerable<Artists> artistsP { get; set; }
        public IEnumerable<Albums> albumsP { get; set; }

    public IEnumerable<Singles> singlesP { get; set; }
    }
}
