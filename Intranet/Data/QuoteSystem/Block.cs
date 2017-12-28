using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AcsIntranet.Data.QuoteSystem
{
    /// <summary>
    /// Represents a block in AutoCAD
    /// </summary>
    public class BlockModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Block Name")]
        public string BlockName { get; set; }

        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }
        
        public string Description { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Q-Flag")]
        public int Qflag { get; set; }
        
        public int Class { get; set; }
        
        [Display(Name = "Spec Number")]
        public int SpecNumber { get; set; }
        
        [Display(Name = "Insertion Point")]
        public string InsertionPoint { get; set; }


        public DateTime Date { get; set; }

    }
}
