using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAppUI.Core
{
   public static class ApplicationPath
    {
        public static string PathTo(string folderName)
        {
           return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", folderName));
        }
    }
}
