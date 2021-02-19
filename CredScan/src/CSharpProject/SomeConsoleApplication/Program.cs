using Azure.Storage.Blobs;
using System;
using System.Net;


namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username = "myUserName";
            string passw = "SomePassw0rd$CredScan";
            string myAPIKey1 = "1233-4234-6545-6732-3433";
            string myAPIKey2 = "1b299efe-f902-4f11-aadc-a9a7c7413cf1";

            string dbConStr = "Server=tcp:abcd-sql.database.windows.net,1433;Initial Catalog=mydb-dev;Persist Security Info=False;User ID=dummyUser;Password=ThisAreMyCr3denti@ls;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string dbConStr1 = "Server=tcp:abcd-sql.database.windows.net,1433;Initial Catalog=mydb-dev;Persist Security Info=False;User ID="+username+";Password="+passw+";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            //Sample ConnectionString: DefaultEndpointsProtocol=https;AccountName=someContainerName;AccountKey=Q9uGl/8vpMm0A7wBCTjDntkKyUFqnYBAlPq2z8pSAK2jALFrkwTeTAjWc6Se7QEi+PWAWv5pcOR82a9nSGaw8w==;EndpointSuffix=core.windows.net
            
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=someContainerName;AccountKey=Q9uGl/8vpMm0A7wBCTjDntkKyUFqnYBAlPq2z8pSAK2jALFrkwTeTAjWc6Se7QEi+PWAWv5pcOR82a9nSGaw8w==;EndpointSuffix=core.windows.net";
            string containerName = "sample-container";

            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            var iAmTrue = true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        public static void NotImplemented() { }

        public static object Passthrough(object obj)
        {
            return obj;
        }


    }
}
