using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Api.Entities
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(200)] 
        public string Name { get; set; } = string.Empty;

        public Cart Cart { get; set; } = null!;
    }
}
