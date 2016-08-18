using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthConnectionLibrary.Tests
{
    [TestClass()]
    public class AuthConnectionTests
    {

        [TestMethod()]
        public void GetResultFromWebServiceTest()
        {
            var auth = new AuthConnection();
            auth.UrlAuthorizationServer = "";
            auth.ClientId = "";
            auth.ClientSecret = "";

            auth.AuthorizationPath = "";
            auth.TokenPath = "";

            var urlWebService = "";

            var resultFromWebService = auth.GetResultFromWebService(urlWebService);

            Assert.IsNotNull(resultFromWebService);

        }
    }
}