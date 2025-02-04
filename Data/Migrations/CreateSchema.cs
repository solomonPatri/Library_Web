using FluentMigrator;
using Microsoft.OpenApi.Services;

namespace Library_Web.Data.Migrations
{
    [Migration(17012025)]

    public class CreateSchema:Migration 
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }




        public override void Up()
        {
            Create.Table("library")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("Name").AsString(120).NotNullable()
                  .WithColumn("Places").AsInt32().NotNullable()
                  .WithColumn("Address").AsString(120).NotNullable()
                  .WithColumn("SoldBooks").AsInt32().NotNullable()
                  .WithColumn("Inauguration").AsDate().NotNullable();
        }

















    }
}
