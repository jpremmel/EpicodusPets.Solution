using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace EpicodusPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string FavoriteThings { get; set; }
        public string LeastFavoriteThings { get; set; }
        public string Owner { get; set; }
        public string PhotoPath { get; set; }

    }
}