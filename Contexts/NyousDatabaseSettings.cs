using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NyousApi.NoSql.Contexts
{
    public class NyousDatabaseSettings : INyousDatabaseSettings
    {
        public string EventosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface INyousDatabaseSettings
    {
       public string EventosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
