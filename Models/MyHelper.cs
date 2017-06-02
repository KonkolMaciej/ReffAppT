using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReffAppT.Models
{
    public static class MyHelper
    {
        public static string ImportPhoto(string scr)
        {
            return string.Format("<img src =" + scr + ">");
        }

        public static string HtmlBody(string str) {
            return String.Format("< html >< head >");
        }
    
            public static MvcHtmlString Image(this HtmlHelper htmlHelper, 
        	string source, string alternativeText)
        {
            //declare the html helper 
            var builder = new TagBuilder("image"); 
            //hook the properties and add any required logic
            builder.MergeAttribute("src", source);
            builder.MergeAttribute("alt", alternativeText);
            //create the helper with a self closing capability
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

        public static IHtmlString Retrieve_Label(this HtmlHelper helper, string content)
        {
            string LableStr =   $"<label style=\"background-color:grey;color:red;font-size:34px\">{content}</label>";
            return new HtmlString(LableStr);
        }
    }
}