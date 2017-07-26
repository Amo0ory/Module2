using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Tab;

namespace Tab
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<myTable> myEasyTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://strength.azurewebsites.net");
            this.myEasyTable = this.client.GetTable<myTable>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task<List<myTable>> GetmyEasyTableInformation()
        {
            return await this.myEasyTable.ToListAsync();
        }
        public async Task PostmyEasyTableInformation(myTable EasyTableModel)
        {
            await this.myEasyTable.InsertAsync(EasyTableModel);
        }
       

    }
}
