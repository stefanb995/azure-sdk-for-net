// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Data Lake Analytics job execution statistics.
    /// </summary>
    public partial class JobStatistics
    {
        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        public JobStatistics() { }

        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        /// <param name="lastUpdateTimeUtc">the last update time for the statistics.</param>
        /// <param name="stages">the list of stages for the job.</param>
        public JobStatistics(DateTimeOffset? lastUpdateTimeUtc = default(DateTimeOffset?), IList<JobStatisticsVertexStage> stages = default(IList<JobStatisticsVertexStage>))
        {
            LastUpdateTimeUtc = lastUpdateTimeUtc;
            Stages = stages;
        }

        /// <summary>
        /// Gets the last update time for the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTimeUtc")]
        public DateTimeOffset? LastUpdateTimeUtc { get; private set; }

        /// <summary>
        /// Gets the list of stages for the job.
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public IList<JobStatisticsVertexStage> Stages { get; private set; }

    }
}