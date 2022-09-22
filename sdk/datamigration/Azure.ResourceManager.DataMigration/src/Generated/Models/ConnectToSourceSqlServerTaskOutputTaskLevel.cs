// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Task level output for the task that validates connection to SQL Server and also validates source server requirements. </summary>
    public partial class ConnectToSourceSqlServerTaskOutputTaskLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary> Initializes a new instance of ConnectToSourceSqlServerTaskOutputTaskLevel. </summary>
        internal ConnectToSourceSqlServerTaskOutputTaskLevel()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
            ResultType = "TaskLevelOutput";
        }

        /// <summary> Initializes a new instance of ConnectToSourceSqlServerTaskOutputTaskLevel. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Type of result - database level or task level. </param>
        /// <param name="databases"> Source databases as a map from database name to database id. </param>
        /// <param name="logins"> Source logins as a map from login name to login id. </param>
        /// <param name="agentJobs"> Source agent jobs as a map from agent job name to id. </param>
        /// <param name="databaseTdeCertificateMapping"> Mapping from database name to TDE certificate name, if applicable. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServerBrandVersion"> Source server brand version. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal ConnectToSourceSqlServerTaskOutputTaskLevel(string id, string resultType, string databases, string logins, string agentJobs, string databaseTdeCertificateMapping, string sourceServerVersion, string sourceServerBrandVersion, IReadOnlyList<ReportableException> validationErrors) : base(id, resultType)
        {
            Databases = databases;
            Logins = logins;
            AgentJobs = agentJobs;
            DatabaseTdeCertificateMapping = databaseTdeCertificateMapping;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            ValidationErrors = validationErrors;
            ResultType = resultType ?? "TaskLevelOutput";
        }

        /// <summary> Source databases as a map from database name to database id. </summary>
        public string Databases { get; }
        /// <summary> Source logins as a map from login name to login id. </summary>
        public string Logins { get; }
        /// <summary> Source agent jobs as a map from agent job name to id. </summary>
        public string AgentJobs { get; }
        /// <summary> Mapping from database name to TDE certificate name, if applicable. </summary>
        public string DatabaseTdeCertificateMapping { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
