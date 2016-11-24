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
        CloudStorageAccount storageAccount;
        CloudTableClient tableClient;
        CloudTable table;

        public HomeController()
        {
            // Parse the connection string and return a reference to the storage account.
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference("people");
            table.CreateIfNotExists();
        }

        [NonAction]
        public List<PoorSoul> ReturnPeopleEntityList(string PartitionKeySearchWord)
        {
            List<PoorSoul> peopleEntityList = new List<PoorSoul>();
            // Construct the query operation for all customer entities where PartitionKey="defaultPartitionKey".
            TableQuery<PoorSoul> query = new TableQuery<PoorSoul>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, PartitionKeySearchWord));

            // Print the fields for each customer.
            foreach (PoorSoul entity in table.ExecuteQuery(query))
            {
                peopleEntityList.Add(entity);
            }

            return peopleEntityList;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(PoorSoul ps)
        {
            if (ModelState.IsValid)
            {
                PoorSoul person = new PoorSoul(Guid.NewGuid().ToString()) { Name = ps.Name, Phone = ps.Phone };

                TableOperation insertOperation = TableOperation.Insert(person);
                table.Execute(insertOperation);

                return View("DoneReg", ps);
            }

            return View();
        }

        [HttpGet]
        public ViewResult SpamList()
        {
            return View(ReturnPeopleEntityList("defaultPartitionKey"));
        }
    }
}