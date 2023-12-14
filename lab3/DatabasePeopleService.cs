using Lab1.Database;
using Microsoft.EntityFrameworkCore;
using PeopleService;


namespace CdvAzure.Functions
{

    public class DatabasePeopleService : PeopleService
    {
        private readonly PeopleDb db;

    }

    public DatabasePeopleService(PeopleDb db)
    {
        this.db = db;
    }

    public IEnumerable<Person> Get()
    {
        var peopleList= db.People.Select;
    }
}

