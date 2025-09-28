using Xunit;

namespace App.School.v3.EntityFrameworkCore;

[CollectionDefinition(v3TestConsts.CollectionDefinitionName)]
public class v3EntityFrameworkCoreCollection : ICollectionFixture<v3EntityFrameworkCoreFixture>
{

}
