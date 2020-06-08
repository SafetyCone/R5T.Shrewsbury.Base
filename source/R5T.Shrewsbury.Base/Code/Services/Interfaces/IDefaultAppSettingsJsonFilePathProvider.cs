using System;


namespace R5T.Shrewsbury
{
    /// <summary>
    /// Service to get the default appsettings.json file path.
    /// </summary>
    /// <remarks>
    /// Not async since startup is (currently) a synchronous process.
    /// </remarks>
    public interface IDefaultAppSettingsJsonFilePathProvider
    {
        string GetDefaultAppSettingsJsonFilePath();
    }
}
