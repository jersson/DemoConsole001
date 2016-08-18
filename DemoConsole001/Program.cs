using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DotNetOpenAuth.OAuth2;
using System.Net.Http;

using AuthConnectionLibrary;

namespace DemoConsole001
{
    class Program
    {
        static void Main(string[] args)
        {

            var auth = new AuthConnection();
            auth.UrlAuthorizationServer = "";
            auth.ClientId = "";
            auth.ClientSecret = "";

            auth.AuthorizationPath = "";
            auth.TokenPath = "";

            var urlWebService = "";

            var resultFromWebService = auth.GetResultFromWebService(urlWebService);


            Console.WriteLine(resultFromWebService);
            Console.ReadKey();
        }

       
    }
}
