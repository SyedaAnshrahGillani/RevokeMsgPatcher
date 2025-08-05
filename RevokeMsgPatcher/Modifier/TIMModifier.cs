using RevokeMsgPatcher.Model;
using RevokeMsgPatcher.Utils;

namespace RevokeMsgPatcher.Modifier
{
    class TIMModifier : ModifierBase
    {
        public override string AppName => "TIM";
        public override string VersionFileName => "IM.dll";

        public TIMModifier(App config) : base(config) { }
