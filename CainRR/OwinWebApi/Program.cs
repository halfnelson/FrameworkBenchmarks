using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.Owin.Hosting;

namespace OwinWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostAddress = "http://*:9000/";
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: hostAddress)) 
            { 
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient(); 

                var response = client.GetAsync(baseAddress + "json").Result; 

                Console.WriteLine(response); 
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                response = client.GetAsync(baseAddress + "plaintext").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine(); 
            } 

            
        } 
    }
}
