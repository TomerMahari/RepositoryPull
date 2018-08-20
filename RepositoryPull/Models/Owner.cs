using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPull.Models
{
    public class Owner
    {
        public string Login { get; set; }
        public int Id { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }        
    }
}