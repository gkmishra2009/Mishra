using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using UnitTest.Controllers;

namespace Tests
{
    public class Tests
    {
       
        
        [Test]
        public void TestSendEmail()
        {
	Try
	{
            var fixture = new Fixture();
            var receiverEmail= fixture.Build<Person>().With("gkmishra2023@gmail.com").Create();
            Bool result = Email_Work.SendEmail(receiverEmail);
            Assert.IsTrue(result);
	    log.Info("Email Has been sent successfully");
	}
	 Catch(Exception Ex)
   	 {
	 logger.LogError(Ex.Message);
   	 }
             
        }
    }
}