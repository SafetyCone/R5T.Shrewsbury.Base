using System;

using R5T.T0064;


namespace R5T.Shrewsbury
{
    [ServiceDefinitionMarker]
    public interface IConfigurationNameSpecificAppSettingsJsonFileNameProvider : IServiceDefinition
    {
        string GetConfigurationNameSpecificAppSettingsJsonFileName(string configurationName);
    }
}
