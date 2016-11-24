using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage.Table;

namespace EmulatorUpgf.Models
{
    public class PoorSoul : TableEntity
    {
        public PoorSoul()
        {
        }

        public PoorSoul(string rowkey)
        {
            this.PartitionKey = "spamListPerson";
            this.RowKey = rowkey;
        }

        [Required(ErrorMessage = "Ange ditt namn")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Ange ditt mobilnummer")]
        public string Phone { get; set; }
    }
}