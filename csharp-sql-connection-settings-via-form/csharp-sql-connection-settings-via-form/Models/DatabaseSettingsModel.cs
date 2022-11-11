using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sql_connection_settings_via_form.Model
{
   public class DatabaseSettingsModel
    {
        public string DataSource { get; set; }

        public string InitialCatalog { get; set; }

        public string UserID { get; set; }

        public string Password { get; set; }

        public bool IntegratedSecurity { get; set; }

        public int ConnectionTimeout { get; set; }
    }
}
