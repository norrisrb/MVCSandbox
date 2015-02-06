using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCSandbox.OpenAccess;

namespace MVCSandbox
{
    public class ContextFactory
    {
        private static readonly string contextKey = typeof (EntitiesModel).FullName;

        public static EntitiesModel GetContextPerRequest()
        {
            HttpContext httpContext = HttpContext.Current;
            if (httpContext == null)
            {
                return new EntitiesModel();
            }
            else
            {
                EntitiesModel context = httpContext.Items[contextKey] as EntitiesModel;

                if (context == null)
                {
                    context = new EntitiesModel();
                    httpContext.Items[contextKey] = context;
                }

                return context;
            }
        }
    }
}