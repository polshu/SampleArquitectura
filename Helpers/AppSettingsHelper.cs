using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers {
    public class AppSettingsHelper {
        public static string GetAppSetting(string key, string defaultValue) {
            string strReturnValue = defaultValue;
            string strValue = ConfigurationManager.AppSettings[key];
            if (strValue != null) {
                strReturnValue = strValue;
            }
            return strReturnValue;
        }
    }
}
