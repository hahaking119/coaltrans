﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Autonomy.Demo.Util;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;

namespace Autonomy.Demo.Bll
{
    public abstract class Query
    {
        public string QueryParam { get; set; }
        public int Start { get; set; }

        public abstract string GetQueryCommand();
        public abstract string GetResult();

        public string DoQuery()
        {
            string actUrl = GetQueryCommand();

            if (actUrl != string.Empty)
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(actUrl);
                myRequest.Method = "GET";
                myRequest.ContentType = "application/x-www-form-urlencoded";

                // Get response
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string content = reader.ReadToEnd();
                XmlDocument contentDoc = new XmlDocument();
                contentDoc.LoadXml(content);

                //Create an XmlNamespaceManager for resolving namespaces.
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(contentDoc.NameTable);
                nsmgr.AddNamespace("autn", "http://schemas.autonomy.com/aci/");

                //Select the book node with the matching attribute value.
                XmlNodeList hits = contentDoc.SelectNodes("autnresponse/responsedata/autn:hit", nsmgr);
                XmlNode TotalNode = contentDoc.SelectSingleNode("autnresponse/responsedata/autn:totalhits", nsmgr);

                int totalCount = 0;
                int pageCount = 0;
                int pageSize = 15;

                if (TotalNode != null && !string.IsNullOrEmpty(TotalNode.InnerText))
                {
                    totalCount = int.Parse(TotalNode.InnerText);
                    int remainder;
                    pageCount = Math.DivRem(totalCount, pageSize, out remainder);
                    if (remainder > 0)
                    {
                        pageCount++;
                    }
                }

                StringBuilder html = new StringBuilder();
                foreach (XmlNode hit in hits)
                {
                    XmlNode document = hit.ChildNodes[7].SelectSingleNode("DOCUMENT");
                    html.AppendFormat("<li><h2><a href=\"{0}\">", document.SelectSingleNode("DREREFERENCE").InnerText);
                    html.AppendFormat("{0}</a></h2>", document.SelectSingleNode("DRETITLE").InnerText);
                    html.Append("<div class=\"d\"><span>" + document.SelectSingleNode("MYSITENAME").InnerText + "</span> - " + document.SelectSingleNode("MYDATE").InnerText + "</div>");
                    html.AppendFormat("<p>{0}<b>...</b></p>", document.SelectSingleNode("DRECONTENT").InnerText);
                    html.Append("</li>");
                }

                html.Append("※").Append(totalCount).Append("※").Append(pageCount);

                return html.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public class SearchQuery : Query
    {
        public override string GetQueryCommand()
        {
            int end = Start + 14;
            string actUrl = ConfigUtil.GetAppSetting("IdolACIPort") + "/action=query&text=" + QueryParam
                          + "&databasematch=" + ConfigUtil.GetAppSetting("DATABASE") + "&print=all&LanguageType=chineseUTF8&start="
                          + Start.ToString() + "&maxresults=" + end.ToString() + "&totalresults=true&minscore=60&outputencoding=utf8";
            return actUrl;
        }

        public override string GetResult()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryQuery : Query
    {
        public override string GetQueryCommand()
        {
            int end = 15;
            string actUrl = ConfigUtil.GetAppSetting("IdolACIPort") + "/action=CategoryQuery&category="
                          + QueryParam + "&Databases=" + ConfigUtil.GetAppSetting("DATABASE")
                          + "&start=" + Start + "&numresults=" + end + "&Params=print&Values=all";
            return actUrl;
        }

        public override string GetResult()
        {
            throw new NotImplementedException();
        }
    }

    public class QueryFactory
    {
        public static Query GetQuery(QueryType queryType)
        {
            switch (queryType)
            {
                case QueryType.Search:
                    return new SearchQuery();
                case QueryType.Category:
                    return new CategoryQuery();
                default:
                    return null;
            }
        }
    }

    public enum QueryType
    {
        Search = 1,
        Category = 2
    }
}

