using Microsoft.Extensions.Options;
using scheduller.data.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace scheduller.data.Services.Interfaces
{
    public interface IComplexJobService
    {
        void SaveComplexJob();
    }
}
