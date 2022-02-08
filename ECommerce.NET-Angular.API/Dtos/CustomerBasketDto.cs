using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ECommerce.NET_Angular.Core.DbModels;

namespace ECommerce.NET_Angular.API.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string Id { get; set; }

        public List<BasketItemDto> Items { get; set; } 
    }
}
