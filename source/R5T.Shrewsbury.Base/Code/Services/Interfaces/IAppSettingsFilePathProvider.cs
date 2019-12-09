using System;


namespace R5T.Shrewsbury
{
    public interface IAppSettingsFilePathProvider
    {
        string GetAppSettingsFilePath(string appSettingsFileName);
    }
}
