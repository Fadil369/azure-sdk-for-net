// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure Database for PostgreSQL and target server requirements for Oracle source. </summary>
    public partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput. </summary>
        internal ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput()
        {
            Databases = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
            DatabaseSchemaMap = new ChangeTrackingList<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>();
        }

        /// <summary> Initializes a new instance of ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput. </summary>
        /// <param name="targetServerVersion"> Version of the target server. </param>
        /// <param name="databases"> List of databases on target server. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="validationErrors"> Validation errors associated with the task. </param>
        /// <param name="databaseSchemaMap"> Mapping of schemas per database. </param>
        internal ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput(string targetServerVersion, IReadOnlyList<string> databases, string targetServerBrandVersion, IReadOnlyList<ReportableException> validationErrors, IReadOnlyList<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem> databaseSchemaMap)
        {
            TargetServerVersion = targetServerVersion;
            Databases = databases;
            TargetServerBrandVersion = targetServerBrandVersion;
            ValidationErrors = validationErrors;
            DatabaseSchemaMap = databaseSchemaMap;
        }

        /// <summary> Version of the target server. </summary>
        public string TargetServerVersion { get; }
        /// <summary> List of databases on target server. </summary>
        public IReadOnlyList<string> Databases { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Validation errors associated with the task. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
        /// <summary> Mapping of schemas per database. </summary>
        public IReadOnlyList<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem> DatabaseSchemaMap { get; }
    }
}
