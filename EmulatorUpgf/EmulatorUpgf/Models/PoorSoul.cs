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

        public PoorSoul(string rowKey)
        {
            this.PartitionKey = "defaultPartitionKey";
            this.RowKey = rowKey;
        }

        public PoorSoul(string partitionKey, string rowKey)
        {
            this.PartitionKey = partitionKey;
            this.RowKey = rowKey;
        }

        [Required(ErrorMessage = "Ange ditt namn")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Ange ditt mobilnummer")]
        public string Phone { get; set; }
    }
}