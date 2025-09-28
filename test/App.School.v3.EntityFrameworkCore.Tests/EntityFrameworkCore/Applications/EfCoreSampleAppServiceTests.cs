using App.School.v3.Samples;
using Xunit;

namespace App.School.v3.EntityFrameworkCore.Applications;

[Collection(v3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<v3EntityFrameworkCoreTestModule>
{

}
