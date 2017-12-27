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
    public class Block
    {
        [Key]
        public string BlockName { get; set; }

        public string PartNumber { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Qflag { get; set; }

        public int Class { get; set; }

        public int SpecNumber { get; set; }

        // System.Drawing.Point serialized as JSON for the database
        public string InsertionPoint { get; set; }
    }
}
