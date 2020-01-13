using IoCConteiners.Models;
using System.Data.Entity;

namespace IoCConteiners.DataAccess
{
    public partial class UserDataModel : DbContext
    {
        public UserDataModel()
            : base("name=UserDataModel")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
