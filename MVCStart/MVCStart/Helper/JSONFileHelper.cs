using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCStart.Models;
using System.IO;
using Newtonsoft.Json;

namespace MVCStart.Helper
{
    public static class JSONFileHelper
    {
        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            try
            {

                using (StreamReader file = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/data.json")))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    clients = (List<Client>)serializer.Deserialize(file, typeof(List<Client>));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clients;
        }
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {

                using (StreamReader file = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/accounts.json")))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    users = (List<User>)serializer.Deserialize(file, typeof(List<User>));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return users;
        }


    }
}