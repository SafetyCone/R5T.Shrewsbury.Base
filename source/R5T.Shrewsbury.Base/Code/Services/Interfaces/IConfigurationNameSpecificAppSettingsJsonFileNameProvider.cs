using System;


namespace R5T.Shrewsbury
{
    public interface IConfigurationNameSpecificAppSettingsJsonFileNameProvider
    {
        string GetConfigurationNameSpecificAppSettingsJsonFileName(string configurationName);
    }
}
