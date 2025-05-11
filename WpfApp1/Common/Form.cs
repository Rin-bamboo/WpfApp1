using System.Windows;
using Wpf_App;
using Wpf_App.Views; // WPF 名前空間を追加

namespace Wpf_App.Common
{
    internal class Form
    {

        /// <summary>
        /// MainWindowのインスタンス
        /// </summary>
        private MainWindow? _mainWindow { get; set; }
        public Window mainWindowOpen()
        {
            this._mainWindow = new MainWindow();
            return this._mainWindow;
        }
        public void mainWindowClose()
        {
            if (this._mainWindow != null)
            {
                this._mainWindow.Close();
                this._mainWindow = null;
            }
        }

    }
}
