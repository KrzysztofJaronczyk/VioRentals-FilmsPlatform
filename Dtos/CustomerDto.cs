using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using VioRentals.Models;

namespace VioRentals.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [AgeValidation]
        public DateTime? DateOfBirth { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}
