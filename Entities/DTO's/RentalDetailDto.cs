using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTO_s
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
        public string UserName { get; set; }
    }
}
