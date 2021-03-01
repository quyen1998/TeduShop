namespace TeduShop.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            //List<PostCategory> listCategory = new List<PostCategory>();
            //listCategory.Add(new PostCategory() { Name= "PostCategory",Alias= "Alias",CreatedBy= "CreatedBy",CreatedDate= DateTime.Now,Description= "Description",DisplayOrder=1,HomeFlag=null,Image=null,MetaDescription=null,MetaKeyword=null,Status=true,ParentID=1 });
        } 
    }
}
