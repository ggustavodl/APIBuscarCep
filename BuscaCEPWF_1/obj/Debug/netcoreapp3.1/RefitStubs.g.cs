﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Refit;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace BuscaCEPWF_1
{
    using RefitInternalGenerated;

    [Preserve]
    partial class AutoGeneratedICeApiService : ICeApiService
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedICeApiService(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<CepResponse> GetAddressAsync(string cep)
        {
            var arguments = new object[] { cep };
            return (Task<CepResponse>) methodImpls["GetAddressAsync"](Client, arguments);
        }

    }
}
