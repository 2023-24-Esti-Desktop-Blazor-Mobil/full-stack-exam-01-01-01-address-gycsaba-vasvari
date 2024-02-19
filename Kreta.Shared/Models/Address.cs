using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Models
{
    public class Address : IDbEntity<Address>
    {
        public Guid Id { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; } = string.Empty;

        public bool IsValidZipCode => ZipCode >0;
        public bool IsStreetValid => ! string.IsNullOrEmpty(Street);

        // Konstruktorok
        // ToString
    }
}
