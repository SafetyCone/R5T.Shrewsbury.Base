using System;


namespace R5T.Shrewsbury
{
    /// <summary>
    /// Get the configuration name-specific appsettings.{Configuration}.json file path.
    /// </summary>
    /// <remarks>
    /// Not async since startup is (currently) a synchronous process.
    /// </remarks>
    public interface IConfigurationNameSpecificAppSettingsJsonFilePathProvider
    {
        string GetConfigurationNameSpecificAppSettingsJsonFilePath();
    }
}
