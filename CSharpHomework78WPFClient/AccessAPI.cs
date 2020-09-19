using CSharpHomework7_8.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework78WPFClient
{
    public static class AccessAPI
    {
        public static HttpClient client;
        
        public static void Initialize()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<T> GetData<T>(string path)
        {
            T res = default(T);
            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    res = await response.Content.ReadAsAsync<T>();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }
    }
}
