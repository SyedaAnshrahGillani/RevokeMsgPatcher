using RevokeMsgPatcher.Model;

namespace RevokeMsgPatcher.Modifier
{
    class ModifierFactory
    {
        public static AppModifier CreateModifier(App config)
        {
            switch (config.Name)
            {
                case "WeChat":
                    return new WechatModifier(config);
                case "QQ":
                    return new QQModifier(config);
                case "TIM":
                    return new TIMModifier(config);
                default:
                    return new WechatModifier(config);
            }
        }
    }
}
