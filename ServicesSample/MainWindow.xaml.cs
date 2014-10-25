using System.Windows;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using ServicesSample.Design;
using ServicesSample.ViewModel;

namespace ServicesSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<MainViewModelService>(this, OpenFilePickerDialog);
        }

        private void OpenFilePickerDialog(MainViewModelService _service)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _service.PickedFileName = dialog.FileName;
                if (_service.FilePicked != null)
                {
                    _service.FilePicked.Invoke();
                }
            }
        }
    }
}