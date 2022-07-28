using Volo.Abp.Settings;

namespace ecaps.Settings;

public class ecapsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ecapsSettings.MySetting1));
    }
}
