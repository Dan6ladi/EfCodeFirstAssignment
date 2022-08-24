using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EfCodeFirst.Model
{
    public class SalesAssociate
    {
        public int SalesAssociateId { get; set; } 
        public string SalesAssociateName { get; set; }  

        [StringLength(10)]
        public string AccountNo { get; set; }

        public string Address { get; set; } 

        public ICollection<Subsidiary> Subsidiaries { get; set; }

    }

    public class Subsidiary 
    {
       
        public int SubsidiaryId { get; set; } 
        
        public string SubsidiaryName { get; set; } 
        
        public SalesAssociate SalesAssociate { get; set; }


    }

}
