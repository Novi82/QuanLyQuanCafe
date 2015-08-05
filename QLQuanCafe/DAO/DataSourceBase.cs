using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.DAO
{
    public abstract class DataSourceBase
    {
        protected MySqlDataProvider provider;

        public DataSourceBase()
        {
            provider = new MySqlDataProvider();
        }
    }
}
