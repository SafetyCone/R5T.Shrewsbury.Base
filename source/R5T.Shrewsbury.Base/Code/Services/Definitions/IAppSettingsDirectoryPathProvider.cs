using System;

using R5T.T0064;


namespace R5T.Shrewsbury
{
    [ServiceDefinitionMarker]
    public interface IAppSettingsDirectoryPathProvider : IServiceDefinition
    {
        string GetAppSettingsDirectoryPath();
    }
}
