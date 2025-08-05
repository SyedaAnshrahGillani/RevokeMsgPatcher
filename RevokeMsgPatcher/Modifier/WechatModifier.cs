using RevokeMsgPatcher.Model;
using RevokeMsgPatcher.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace RevokeMsgPatcher.Modifier
{
        class WechatModifier : ModifierBase
    {
        public override string VersionFileName => "WeChatWin.dll";

        public WechatModifier(App config) : base(config) { }
    {
        public override string AppName => "Wechat";
        public override string RegistryKey => "Wechat";
        public override string VersionFileName => "WeChatWin.dll";

        public WechatModifier(App config) : base(config) { }
