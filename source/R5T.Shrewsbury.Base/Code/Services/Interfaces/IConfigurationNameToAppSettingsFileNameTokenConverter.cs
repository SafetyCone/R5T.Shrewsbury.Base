using System;


namespace R5T.Shrewsbury
{
    public interface IConfigurationNameToAppSettingsFileNameTokenConverter
    {
        string ConvertConfigurationNameToAppSettingsFileNameToken(string configurationName);
    }
}
