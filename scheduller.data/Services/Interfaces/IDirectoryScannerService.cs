using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduller.data.Services.Interfaces
{
    public interface IDirectoryScannerService
    {
        void ScanDeactivatedAccounts();
    }
}
