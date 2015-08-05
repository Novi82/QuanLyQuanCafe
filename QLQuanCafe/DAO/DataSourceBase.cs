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
