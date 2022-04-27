using System;

using R5T.T0064;


namespace R5T.Shrewsbury
{
    /// <summary>
    /// Service to get the default appsettings.json file path.
    /// </summary>
    /// <remarks>
    /// Not async since startup is (currently) a synchronous process.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IDefaultAppSettingsJsonFilePathProvider : IServiceDefinition
    {
        string GetDefaultAppSettingsJsonFilePath();
    }
}
