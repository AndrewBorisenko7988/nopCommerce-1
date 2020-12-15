using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations.Indexes
{
    [NopMigration("2020/12/15 12:34:16:2551770", "Product. Add author")]
    class AddProductAuthor: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Column(nameof(Product.Author))
            .OnTable(nameof(Product))
            .AsString(255)
            .Nullable();
        }
    }
}
