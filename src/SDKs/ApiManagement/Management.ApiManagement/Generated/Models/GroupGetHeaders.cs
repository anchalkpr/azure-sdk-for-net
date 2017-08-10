// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Get operation.
    /// </summary>
    public partial class GroupGetHeaders
    {
        /// <summary>
        /// Initializes a new instance of the GroupGetHeaders class.
        /// </summary>
        public GroupGetHeaders()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupGetHeaders class.
        /// </summary>
        /// <param name="eTag">Current entity state version. Should be treated
        /// as opaque and used to make conditional HTTP requests.</param>
        public GroupGetHeaders(string eTag = default(string))
        {
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current entity state version. Should be treated as
        /// opaque and used to make conditional HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

    }
}
