// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// All Operations related to Volume Containers
    /// </summary>
    public partial interface IDataContainerOperations
    {
        /// <summary>
        /// The Begin Creating Volume Container operation creates a new volume
        /// container.
        /// </summary>
        /// <param name='deviceId'>
        /// device id
        /// </param>
        /// <param name='containerDetails'>
        /// Parameters supplied to the Begin Creating Volume Container
        /// operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<TaskResponse> BeginCreatingAsync(string deviceId, DataContainerRequest containerDetails, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Deleting Volume Container operation deletes the specified
        /// volume container.
        /// </summary>
        /// <param name='deviceId'>
        /// device id
        /// </param>
        /// <param name='dataContainerId'>
        /// id of data container which needs to be deleted
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<TaskResponse> BeginDeletingAsync(string deviceId, string dataContainerId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='deviceId'>
        /// device id
        /// </param>
        /// <param name='containerDetails'>
        /// Parameters supplied to the Create Volume Container operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> CreateAsync(string deviceId, DataContainerRequest containerDetails, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='deviceId'>
        /// device id
        /// </param>
        /// <param name='dataContainerId'>
        /// id of data container which needs to be deleted
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> DeleteAsync(string deviceId, string dataContainerId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get of data containers.
        /// </returns>
        Task<DataContainerGetResponse> GetAsync(string deviceId, string dataContainerName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list of data containers.
        /// </returns>
        Task<DataContainerListResponse> ListAsync(string deviceId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}