using System.ComponentModel.DataAnnotations;

namespace GraphQLDotnet.Models
{

    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        public string Stockcode { get; set; }

        public string ArticleName { get; set; }

        public string ArticleDescription { get; set; }
    }
}