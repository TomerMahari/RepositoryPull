using RepositoryPull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace RepositoryPull.Api
{
    public class BookmarkApi
    {
        public bool Add(RepositoryItem item)
        {
            var session = HttpContext.Current?.Session;
            if (item == null || session == null)
                return false;
            var repositoriesBookmark = session["RepositoriesBookmark"] as List<RepositoryItem>;

            if (repositoriesBookmark == null)
            {

                repositoriesBookmark = new List<RepositoryItem>();
            }
            if (repositoriesBookmark.FirstOrDefault(x => x.Id == item.Id) != null)
                return false;
            repositoriesBookmark.Add(item);
            session["RepositoriesBookmark"] = repositoriesBookmark;
            return true;
        }
        public List<RepositoryItem> GetBookmarks()
        {
            var session = HttpContext.Current?.Session;
            var repositoriesBookmark = session["RepositoriesBookmark"] as List<RepositoryItem>;

            if (repositoriesBookmark == null)
            {

                repositoriesBookmark = new List<RepositoryItem>();
            }
            return repositoriesBookmark;
        }
    }
}