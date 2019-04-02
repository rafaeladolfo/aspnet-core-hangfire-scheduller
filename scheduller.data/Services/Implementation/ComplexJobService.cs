using Microsoft.Extensions.Options;
using scheduller.data.DAO.Implementation;
using scheduller.data.DAO.Interfaces;
using scheduller.data.Domain;
using scheduller.data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace scheduller.data.Services.Implementation
{
    public class ComplexJobService : IComplexJobService
    {
        public void SaveComplexJob()
        {
            IComplexJobDAO complexJobDAO = new ComplexJobDAO();

            complexJobDAO.SaveComplexJob("This was a test at:" + DateTime.Now);
        }

    }
}
