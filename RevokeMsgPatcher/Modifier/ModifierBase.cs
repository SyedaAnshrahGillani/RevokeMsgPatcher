using RevokeMsgPatcher.Model;

namespace RevokeMsgPatcher.Modifier
{
    public abstract class ModifierBase : AppModifier
    {
        public abstract string VersionFileName { get; }

        protected ModifierBase(App config)
        {
            this.config = config;
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
            return string.Empty;
        }

        public override void AfterPatchSuccess() { }

        public override void AfterPatchFail() { }
    }
}
