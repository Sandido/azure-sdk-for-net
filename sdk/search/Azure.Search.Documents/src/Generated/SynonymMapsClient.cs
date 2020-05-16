// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    /// <summary> The SynonymMaps service client. </summary>
    internal partial class SynonymMapsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SynonymMapsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SynonymMapsClient for mocking. </summary>
        protected SynonymMapsClient()
        {
        }
        /// <summary> Initializes a new instance of SynonymMapsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal SynonymMapsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-05-06-Preview")
        {
            RestClient = new SynonymMapsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> CreateOrUpdateAsync(string synonymMapName, SynonymMap synonymMap, Guid? xMsClientRequestId = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(synonymMapName, synonymMap, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new synonym map or updates a synonym map if it already exists. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to create or update. </param>
        /// <param name="synonymMap"> The definition of the synonym map to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> CreateOrUpdate(string synonymMapName, SynonymMap synonymMap, Guid? xMsClientRequestId = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(synonymMapName, synonymMap, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string synonymMapName, Guid? xMsClientRequestId = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a synonym map. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to delete. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string synonymMapName, Guid? xMsClientRequestId = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(synonymMapName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> GetAsync(string synonymMapName, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(synonymMapName, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a synonym map definition. </summary>
        /// <param name="synonymMapName"> The name of the synonym map to retrieve. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> Get(string synonymMapName, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(synonymMapName, xMsClientRequestId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListSynonymMapsResult>> ListAsync(string select = null, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(select, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all synonym maps available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the synonym maps to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListSynonymMapsResult> List(string select = null, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(select, xMsClientRequestId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynonymMap>> CreateAsync(SynonymMap synonymMap, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(synonymMap, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new synonym map. </summary>
        /// <param name="synonymMap"> The definition of the synonym map to create. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynonymMap> Create(SynonymMap synonymMap, Guid? xMsClientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SynonymMapsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(synonymMap, xMsClientRequestId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
