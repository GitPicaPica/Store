using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage ="El campo {0} Contiene demaciado Caracteres")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchate")]
        public DateTime ? LastPurchate { get; set; }
        [Display(Name = "Las Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name="Is Available ?")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public double Stock { get; set; }
            
        }

    }

