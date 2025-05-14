using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UglyWPF.Unit;

namespace UglyWPF.ViewModel
{
    public class MainWindowsViewModel: ObservableObject 
    { 
        public MainWindowsViewModel()
        {
            SwitchCNLanguageCommand = new RelayCommand(LanguageEvent);
            SwitchENLanguageCommand = new RelayCommand(LanguageEvent2);

        }
        /// <summary>
        /// Gets the <see cref="ICommand"/>Language<see cref="CN Language"/>.
        /// </summary>
        public ICommand SwitchCNLanguageCommand { get; }
        /// <summary>
        /// Gets the <see cref="ICommand"/>Language<see cref="EN Language"/>.
        /// </summary>
        public ICommand SwitchENLanguageCommand { get; }

        private void LanguageEvent() {
            if (LanguageManager.CurrentLanguage.Source.OriginalString.Contains("en-US"))
            {
                LanguageManager.CurrentLanguage = new ResourceDictionary { Source = new Uri("Resources.zh-CN.xaml", UriKind.Relative) };
                Operation = OperationManager.GetUserStatusTxt("", "Chinese Switching Successful");// $"中文切换成功
            }
        }
        private void LanguageEvent2()
        {
            if (LanguageManager.CurrentLanguage.Source.OriginalString.Contains("zh-CN"))
            {
                LanguageManager.CurrentLanguage = new ResourceDictionary { Source = new Uri("Resources.en-US.xaml", UriKind.Relative) };
                Operation = OperationManager.GetUserStatusTxt("", "English Switching Successful"); // "英文切换成功";
            }
        }
        private string _operation;
        public string Operation
        {
            get => _operation;
            set { _operation = value; OnPropertyChanged(nameof(Operation)); }
        }
        
    }
}
