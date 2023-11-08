using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEPWF_1
{
    interface ICeApiService
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponse> GetAddressAsync(string cep);
       

    }
}
