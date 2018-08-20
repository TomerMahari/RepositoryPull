using Newtonsoft.Json;
using RepositoryPull.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RepositoryPull.Api
{
    public class GitApi : BaseApi
    {
        private string _apiUrl => ConfigurationManager.AppSettings["GithubApiUrl"];
        // Get all repositories from Github api.
        //returns repositoryitem
        public List<RepositoryItem> GetRepositories(string query)
        {
            var url = _apiUrl + query;            
            var responseApi = Get(url, userAgent: "my user agent");
            try
            {
                var rootObj = JsonConvert.DeserializeObject<RootObject>(responseApi);
                if (rootObj != null)
                {
                    return rootObj.Items;
                }
                
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}