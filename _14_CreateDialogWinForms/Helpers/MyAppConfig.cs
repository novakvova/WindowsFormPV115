using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateDialogWinForms.Helpers
{
    public static class MyAppConfig
    {
        public static string GetSectionValue(string section)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("myconfig.json");
            var config = configBuilder.Build();
            var data = config.GetSection(section).Value;
            return data;
        }
    }
}
