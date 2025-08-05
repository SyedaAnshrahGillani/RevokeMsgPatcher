using RevokeMsgPatcher.Model;
using RevokeMsgPatcher.Utils;
using System;
using System.Collections.Generic;

namespace RevokeMsgPatcher.Modifier
{
    class QQModifier : CommonModifier
    {
        public override string AppName => "QQ";
        public override string RegistryKey => "{052CFB79-9D62-42E3-8A15-DE66C2C97C3E}";
        public override string VersionFileName => "IM.dll";

        public QQModifier(App config) : base(config) { }
