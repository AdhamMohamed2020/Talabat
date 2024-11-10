using System.ComponentModel.DataAnnotations.Schema;

namespace Talabat.Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }

        public AppUser User { get; set; }
    }
}