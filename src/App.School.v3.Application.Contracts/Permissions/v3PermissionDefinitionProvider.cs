using App.School.v3.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace App.School.v3.Permissions;

public class v3PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(v3Permissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(v3Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<v3Resource>(name);
    }
}
