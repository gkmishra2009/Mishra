using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Home.Models;

namespace Home.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger _logger;   

       
	//Use of Constructors
	public HomeController(ILogger<HomeController> logger)  
	{ 
          //Use of Dependency Injection
   	 _logger = logger;   
	}
        public async void invokeEmailMethod()
        {
	 // Use of Static Class
   	 try{
	 EmailWork.SendMail("gkmishra2023@gmail.com");
         log.Info("Email Has been sent successfully");
    	}
   	 Catch(Exception Ex)
   	 {
	 logger.LogError(Ex.Message);
   	 }
	}
    }
}
