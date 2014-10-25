using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using ServicesSample.Design;

namespace ServicesSample.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string _fileName;
        private MainViewModelService _service;
        public RelayCommand GetFile { get; private set; }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                RaisePropertyChanged("FileName");
            }
        }

        public MainViewModel()
        {
            this.GetFile = new RelayCommand(() => Messenger.Default.Send(_service));
            _service = new MainViewModelService();
            _service.FilePicked = this.FilePicked;
        }

        private void FilePicked()
        {
            this.FileName = _service.PickedFileName;
        }




    }
}