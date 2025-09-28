using App.School.v3.Samples;
using Xunit;

namespace App.School.v3.EntityFrameworkCore.Domains;

[Collection(v3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<v3EntityFrameworkCoreTestModule>
{

}
