using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPull.Models
{
    public class RootObject
    {
        public List<RepositoryItem> Items { get; set; }

        
    }
}