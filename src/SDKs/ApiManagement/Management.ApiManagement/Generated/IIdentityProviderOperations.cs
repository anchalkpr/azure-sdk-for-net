// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IdentityProviderOperations operations.
    /// </summary>
    public partial interface IIdentityProviderOperations
    {
        /// <summary>
        /// Lists a collection of Identity Provider configured in the specified
        /// service instance.
        /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-aad#how-to-authorize-developer-accounts-using-azure-active-directory" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IdentityProviderList>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the configuration details of the identity Provider configured
        /// in specified service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='identityProviderName'>
        /// Identity Provider Type identifier. Possible values include:
        /// 'facebook', 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IdentityProviderContract,IdentityProviderGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, IdentityProviderType identityProviderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or Updates the IdentityProvider configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='identityProviderName'>
        /// Identity Provider Type identifier. Possible values include:
        /// 'facebook', 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
        /// </param>
        /// <param name='parameters'>
        /// Create parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IdentityProviderContract>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, IdentityProviderType identityProviderName, IdentityProviderContract parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing IdentityProvider configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='identityProviderName'>
        /// Identity Provider Type identifier. Possible values include:
        /// 'facebook', 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
        /// </param>
        /// <param name='parameters'>
        /// Update parameters.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (Etag) version of the identity provider
        /// configuration to update. A value of "*" can be used for If-Match to
        /// unconditionally apply the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, IdentityProviderType identityProviderName, IdentityProviderUpdateParameters parameters, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified identity provider configuration.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='identityProviderName'>
        /// Identity Provider Type identifier. Possible values include:
        /// 'facebook', 'google', 'microsoft', 'twitter', 'aad', 'aadB2C'
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (Etag) version of the backend to delete. A value
        /// of "*" can be used for If-Match to unconditionally apply the
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, IdentityProviderType identityProviderName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
