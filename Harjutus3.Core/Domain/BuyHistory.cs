using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus3.Core.Domain
{
    public class BuyHistory
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ClientID")]
        public Clients Client { get; set; }
        [ForeignKey("ProductID")]
        public Products Product { get; set; }
    }
}
