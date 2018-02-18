namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMigrationType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, TypeInMonths, DiscountRate) VALUES (1,0,0,0) ");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, TypeInMonths, DiscountRate) VALUES (2,30,1,10) ");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, TypeInMonths, DiscountRate) VALUES (4,300,12,20) ");
        }
        
        public override void Down()
        {
        }
    }
}
