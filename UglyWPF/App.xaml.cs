using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UglyWPF
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // 设置初始语言，例如中文
            LanguageManager.CurrentLanguage = new ResourceDictionary { Source = new Uri("Resources.zh-CN.xaml", UriKind.Relative) };

            base.OnStartup(e);
        }
    }
}
