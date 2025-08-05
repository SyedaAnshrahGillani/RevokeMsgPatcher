using RevokeMsgPatcher.Model;
using RevokeMsgPatcher.Utils;
using System;
using System.Collections.Generic;

namespace RevokeMsgPatcher.Modifier
{
    class QQModifier : ModifierBase
    {
        public override string VersionFileName => "IM.dll";

        public QQModifier(App config) : base(config) { }
