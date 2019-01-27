using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookSiteV2.Controllers
{
    public class comicBooksController : Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello from the comic books control"
            };
        }
    }
}