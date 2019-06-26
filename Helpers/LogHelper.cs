using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers {
    public class LogHelper {
        public static bool WriteToFile(string strPathFile, string strData) {
            return WriteToFileInternal(strPathFile, strData, FileMode.Create);
        }

        public static bool AppendToFile(string strPathFile, string strData) {
            return WriteToFileInternal(strPathFile, strData, FileMode.Append);
        }

        private static bool WriteToFileInternal(string strPathFile, string strData, FileMode fileMode) {
            bool blnReturnValue = false;
            try {
                using (FileStream fs = new FileStream(strPathFile, fileMode, FileAccess.Write, FileShare.ReadWrite)) {
                    using (StreamWriter sw = new StreamWriter(fs)) {
                        sw.Write(strData);
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }
                blnReturnValue = true;
            } catch {
            }
            return blnReturnValue;
        }

    }
}
