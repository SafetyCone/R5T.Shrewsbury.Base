using System;


namespace R5T.Shrewsbury
{
    /// <summary>
    /// AppSettings files can have a filename token indicating that a particular AppSettings file is for a particular configuration.
    /// This service gets the filename token corresponding to a configuration name.
    /// </summary>
    public interface IConfigurationNameToAppSettingsFileNameTokenConverter
    {
        string ConvertConfigurationNameToAppSettingsFileNameToken(string configurationName);
    }
}
