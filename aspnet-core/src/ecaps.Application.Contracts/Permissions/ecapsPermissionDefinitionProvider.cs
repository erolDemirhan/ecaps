using ecaps.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ecaps.Permissions;

public class ecapsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ecapsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ecapsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ecapsResource>(name);
    }
}
