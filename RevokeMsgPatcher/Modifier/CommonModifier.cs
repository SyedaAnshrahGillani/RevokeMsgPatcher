using RevokeMsgPatcher.Model;
using RevokeMsgPatcher.Utils;
using System;
using System.Collections.Generic;

namespace RevokeMsgPatcher.Modifier
{
    abstract class CommonModifier : AppModifier
    {
        public abstract string AppName { get; }
        public abstract string RegistryKey { get; }
        public abstract string VersionFileName { get; }

        public CommonModifier(App config)
        {
            this.config = config;
        }

        public override string FindInstallPath()
        {
            try
            {
                string installPath = PathUtil.FindInstallPathFromRegistry(RegistryKey);
                if (IsAllFilesExist(installPath))
                {
                    return installPath;
                }

                List<string> defaultPathList = PathUtil.GetDefaultInstallPaths($"Tencent\{AppName}");
                foreach (string defaultPath in defaultPathList)
                {
                    if (IsAllFilesExist(defaultPath))
                    {
                        return defaultPath;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public override string GetVersion()
        {
            if (editors != null && editors.Count > 0)
            {
                foreach (FileHexEditor editor in editors)
                {
                    if (editor.FileName == VersionFileName)
                    {
                        return editor.FileVersion;
                    }
                }
            }
            return "";
        }

        public override void AfterPatchSuccess() { }

        public override void AfterPatchFail() { }
    }
}
