using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Lab1.Database;

public class DatabaseContextContextFactory : IDesignTimeDbContextFactory<PeopleDb>
{
    public PeopleDb CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PeopleDb>();
        optionsBuilder.UseSqlServer("Server=tcp:cdvdbserver1.database.windows.net,1433;Initial Catalog=cdvdbserver;Persist Security Info=False;User ID=kacper;Password=MySuperPassword12#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new PeopleDb(optionsBuilder.Options);
    }
}