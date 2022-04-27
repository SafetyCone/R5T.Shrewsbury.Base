using System;

using R5T.T0064;


namespace R5T.Shrewsbury
{
    [ServiceDefinitionMarker]
    public interface IAppSettingsFilePathProvider : IServiceDefinition
    {
        string GetAppSettingsFilePath(string appSettingsFileName);
    }
}
