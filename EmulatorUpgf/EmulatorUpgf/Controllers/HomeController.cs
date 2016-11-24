using EmulatorUpgf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace EmulatorUpgf.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public string GenerateRowKeyInStringFormat()
        {
            Guid rowKey = Guid.NewGuid();
            string s = rowKey.ToString();
            
            return s;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(PoorSoul ps)
        {
            if(ModelState.IsValid)
            {
                PoorSoul person = new PoorSoul(GenerateRowKeyInStringFormat()) { Name = ps.Name, Phone = ps.Phone };

                // Parse the connection string and return a reference to the storage account.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    CloudConfigurationManager.GetSetting("StorageConnectionString")
                );

                // Create the table client.
                CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

                // Retrieve a reference to the table.
                CloudTable table = tableClient.GetTableReference("people");

                // Create the table if it doesn't exist.
                table.CreateIfNotExists();

                // Create the TableOperation object that inserts the customer entity.
                TableOperation insertOperation = TableOperation.Insert(person);

                // Execute the insert operation.
                table.Execute(insertOperation);

                return View("DoneReg", ps);
            }

            return View();
        }
    }
}