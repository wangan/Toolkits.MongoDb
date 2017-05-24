using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkits.MongoDb {
    public abstract class MongoDbConfig : ConfigBase {
        public static string MongoDbConn { get; set; }

        static MongoDbConfig() {
            MongoDbConn = GetConfigInfo<string>("MongoDbConn", "");
        }
    }
}
