using Microsoft.EntityFrameworkCore;

namespace Lab3.Rest.Database
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options) : base(options)
        {
            
        }

    }
}