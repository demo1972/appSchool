using Volo.Abp.Settings;

namespace App.School.v3.Settings;

public class v3SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(v3Settings.MySetting1));
    }
}
