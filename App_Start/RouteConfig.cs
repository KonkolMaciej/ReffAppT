using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReffAppT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MatchIndex",
                url: "meczeLista",
                defaults: new { controller = "Matches", action = "Index" }
);

            routes.MapRoute(
               name: "MatchDelete",
               url: "mecz/usun/meczNumer-{id}",
               defaults: new { controller = "Matches", action = "Delete", id = UrlParameter.Optional }
);
            routes.MapRoute(
                name: "MatchEdit",
                url: "mecz/edycja/meczNumer-{id}",
                defaults: new { controller = "Matches", action = "Edit", id = UrlParameter.Optional }
);

            routes.MapRoute(
                name: "MatchDetails",
                url: "mecz/szczegoly/mecz-{Id}",
                defaults: new { controller = "Matches", action = "Details", id = UrlParameter.Optional }
);

            routes.MapRoute(
                name: "Matchdd",
                url: "Mecz/dodaj",
                defaults: new { controller = "Matches", action = "create" }
);

            routes.MapRoute(
                name: "RefereeAdd",
                url: "sedziowie/dodaj",
                defaults: new { controller = "Referees", action = "create" }
);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
