using System.Windows;
using Utility.Util;
using Wpf_App.Common.Enum;
using WpfApp1.Page;
using static Wpf_App.Common.Enum.CommonEnum;

namespace Wpf_App.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Handle button click
            var result = Dialog.Show(
                "情報の確認がされました",
                "情報_1",
                EnumDialogButtons.OkCancel,
                EnumDialogType.Information);
            switch (result)
            {
                case CommonEnum.EnumDialogResult.Ok:
                    // 実行
                    break;
                case CommonEnum.EnumDialogResult.Cancel:
                    // キャンセル
                    break;
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Handle button click
            var result = Dialog.Show(
                "実行しますか？",
                "質問_1",
                EnumDialogButtons.Ok,
                EnumDialogType.Question);
            switch (result)
            {
                case CommonEnum.EnumDialogResult.Ok:
                    // 実行
                    break;
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Handle button click
            var result = Dialog.Show(
                "警告です",
                "警告_1",
                EnumDialogButtons.YesNo,
                EnumDialogType.Warning);
            switch (result)
            {
                case CommonEnum.EnumDialogResult.Yes:
                    // 実行
                    break;
                case CommonEnum.EnumDialogResult.No:
                    // キャンセル
                    break;
            }
        }
        private void throwTest(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[] { 1, 2, 3 };
            int value = numbers[10];
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Handle menu item click
            MessageBox.Show("Menu item clicked!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}