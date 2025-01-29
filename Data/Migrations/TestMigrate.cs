using FluentMigrator;
using System.Security.Policy;

namespace Library_Web.Data.Migrations
{
    [Migration(17112025)]
    public class TestMigrate:Migration
    {

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {

            Execute.Script(@"Data/scripts/data.sql");
            

        }







    }
}
