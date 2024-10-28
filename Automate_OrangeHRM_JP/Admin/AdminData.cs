using Newtonsoft.Json.Linq;
using Automate_OrangeHRM_JP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Automate_OrangeHRM_JP
{
    public class AdminData : BasePage
    {
        public static string filename = "Admin.json";
        public static JObject? AdminJ = ReadJson(@"JsonFile\AdminJ.json".ToString());
        public static string Username = AdminJ.SelectToken("Uname").Value<string>();
        public static string Pass = AdminJ.SelectToken("Password").Value<string>();
        public static string Pasconfirm = AdminJ.SelectToken("PasswordConfirm").Value<string>();


        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\"+filename);
            var myJObject = JObject.Parse(myJsonString);
            return myJObject;
        }
    }
}
