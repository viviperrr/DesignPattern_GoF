using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Model
{
    public class AppSettings
    {
        public EmailSetting EmailSetting { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class EmailSetting
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string MailServer { get; set; }
        public int MailPort { get; set; }
        public bool EnableSSL { get; set; }
    }

    public class ConnectionStrings
    {
        public string BloggingDatabase { get; set; }
        public string PortfolioDatabase { get; set; }
    }
}
