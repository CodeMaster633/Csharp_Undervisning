using System.Data.Entity;
using Microsoft.EntityFrameworkCore;



namespace StuderendeDataAccess.Context
{
    internal class StuderendeContext : DbContext

    {
        public StuderendeContext() {
            bool created = Database.EnsureCreated();
        }
    }
}
