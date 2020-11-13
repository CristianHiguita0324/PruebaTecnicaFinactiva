using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Cls
{
    public static class CreateResponseService
    {
        public static ResponseService execute(string code, string description, string AdditionalInformation)
        {
            ResponseService response = new ResponseService();

            response.Code = code;
            response.Description = description;
            response.AdditionalInformation = AdditionalInformation;

            return response;
        }
    }
}
