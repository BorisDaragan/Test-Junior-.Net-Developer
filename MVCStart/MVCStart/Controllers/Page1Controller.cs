using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStart.Helper;
using MVCStart.Models;

namespace MVCStart.Controllers
{
    public class Page1Controller : Controller
    {
        List<Client> clients = JSONFileHelper.GetClients();
        //
        // GET: /Page1/
        public ActionResult Index(string tag)
        {
            if (tag == null)
            {

                return View(clients);
            }
            else
            {

                List<Client> clientsWithTag = new List<Client>();
                foreach (var client in clients)
                {
                    foreach (string t in client.tags)
                    {
                        if (t == tag)
                        {
                            clientsWithTag.Add(client);
                            break;
                        }
                    }
                }
                return View(clientsWithTag);
            }

        }

        public ActionResult ClientInfo(int id)
        {
            return View(clients[id]);
        }

        public ActionResult GroupedByTag(string tag)
        {
            List<Client> clientsWithTag = new List<Client>();
            foreach (var client in clients) 
            {
                foreach (string t in client.tags)
                {
                    if(t == tag)
                    {
                        clientsWithTag.Add(client);
                        break;
                    }
                }
            }
            return View(clientsWithTag);
        }
	}
}