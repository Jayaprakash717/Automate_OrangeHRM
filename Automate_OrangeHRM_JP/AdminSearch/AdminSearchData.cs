using Newtonsoft.Json.Linq;
using Automate_OrangeHRM_JP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate_OrangeHRM_JP
{
    public class AdminSearchData : BasePage
    {
        public static string filename = "AdminSearchJ.json";
        public static JObject? AdminSearchJ = ReadJson(@"JsonFile\AdminSearchJ.json".ToString());
        public static string Username = AdminSearchJ.SelectToken("username").Value<string>(); 
        public static string EditUsername = AdminSearchJ.SelectToken("editusername").Value<string>(); 

        public static JObject ReadJson(string filename)
        {
            string myjsonstring = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myJObjct = JObject.Parse(myjsonstring);
            return myJObjct;
        }
    }
}
