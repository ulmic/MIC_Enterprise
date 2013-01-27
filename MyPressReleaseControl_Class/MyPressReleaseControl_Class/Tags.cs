using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo
{
    public class Tags
    {
        private string insertTag(string sel, string tagName, bool HasClose = true)
        {
            int index = tagName.IndexOf(' ');
            if (index > 0)
            {
                return ("<" + tagName + ">" + sel + (HasClose ? "</" + tagName.Substring(0, tagName.IndexOf(' ')) + ">" : " "));
            }
            else
            {
                return ("<" + tagName + ">" + sel + (HasClose ? "</" + tagName + ">" : " "));
            }
        }
        
        public string tagStrike(string htmlCode)
        {
            return htmlCode = insertTag(htmlCode, "s");
        }

        public string tagParagraph(string htmlCode)
        {
            return htmlCode = insertTag(htmlCode, "p");
        }

        public string tagH1(string htmlCode)
        {
            return htmlCode = insertTag(htmlCode, "h1");
        }
                
        public string tagUpIndex(string htmlCode)
        {
            return htmlCode = insertTag(htmlCode, "sup");
        }

        public string tagLowIndex(string htmlCode)
        {
            return htmlCode = insertTag(htmlCode, "sub");
        }

    }



}
