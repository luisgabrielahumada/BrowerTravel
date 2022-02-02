using Core.Component.Library.SQL;

namespace BrowerTravel.Repository
{
    public class AppDatabase : IDatabase
    {
        public AppDatabase(string cnn)
        {
            this.ConnectionString = cnn;
        }
    }
}