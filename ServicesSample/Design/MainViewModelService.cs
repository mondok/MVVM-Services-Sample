using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesSample.Design
{
    public class MainViewModelService
    {
        public string PickedFileName { get; set; }
        public Action FilePicked { get; set; }
    }
}
