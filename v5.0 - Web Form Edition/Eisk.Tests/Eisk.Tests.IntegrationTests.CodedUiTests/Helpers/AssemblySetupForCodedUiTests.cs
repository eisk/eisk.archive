﻿/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Architecture Designed and Implemented By:
Mohammad Ashraful Alam
Microsoft Most Valuable Professional, ASP.NET 2007 – 2011
Twitter: http://twitter.com/AshrafulAlam | Blog: http://blog.ashraful.net | Portfolio: http://www.ashraful.net
   
*******************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eisk.TestHelpers;

namespace Eisk.TestHelpers
{
    [TestClass()]
    public class AssemblySetupForCodedUiTests
    {
        [AssemblyInitialize()]
        public static void InitializeAssembly(TestContext ctx)
        {
            WebServerHelper.StartWebServerIfNotStarted();
            TestDataHelper.CreateDatabaseIfDoesNotExist();
            TestDataHelper.CreateSchema();
        }

        [AssemblyCleanup()]
        public static void CleanupAssembly()
        {
            //WebServerHelper.StopWebServer();
        }
    }
}
