using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPull.Models
{
    public class RepositoryItem
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public Owner Owner { get; set; }
    }
}