﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PTSLibrary;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    private PTSCustomerFacade facade;

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        facade = new PTSCustomerFacade();
    }

    [WebMethod]
    public int Authenticate(string username, string password)
    {
        return facade.Authenticate(username, password);
    }
   [WebMethod]
    public Project[] GetListOfProjects (int customerId)
    {
        return facade.GetListOfProjects(customerId);
    }
    
}
