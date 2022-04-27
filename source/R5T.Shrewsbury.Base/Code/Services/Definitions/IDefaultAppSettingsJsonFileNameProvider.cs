using System;

using R5T.T0064;


namespace R5T.Shrewsbury
{
    /// <summary>
    /// Provides the default appsettings.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDefaultAppSettingsJsonFileNameProvider : IServiceDefinition
    {
        string GetDefaultAppSettingsJsonFileName();
    }
}
