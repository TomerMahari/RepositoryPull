using Newtonsoft.Json;
using RepositoryPull.Api;
using RepositoryPull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;

namespace RepositoryPull.Controllers
{
    public class GitController : ApiController
    {
        // Get request by query from github api.
        // Params {query}.
        [HttpGet, Route("~/api/git/getrepositories/{query}")]
        public object GetRepositories(string query) => new GitApi().GetRepositories(query);       
        [HttpPost, Route("~/api/git/addbookmark")]
        public bool AddBookmark(RepositoryItem item)
        {
            // Add bookmark to session/
            BookmarkApi bookmark = new BookmarkApi();
            return bookmark.Add(item);
        }
        [HttpPost, Route("~/api/git/getbookmarks")]
        public object GetBookmarks()
        {
            BookmarkApi bookmark = new BookmarkApi();
            return bookmark.GetBookmarks();
        }

    }
}