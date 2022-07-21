using System.ComponentModel.DataAnnotations;

namespace GraphQLDotnet.Models
{

    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        public string LicenceKey { get; set; }
    }
}