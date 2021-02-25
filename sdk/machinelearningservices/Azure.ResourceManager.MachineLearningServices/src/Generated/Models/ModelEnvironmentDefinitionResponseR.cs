// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Settings for a R environment. </summary>
    public partial class ModelEnvironmentDefinitionResponseR : RSectionResponse
    {
        /// <summary> Initializes a new instance of ModelEnvironmentDefinitionResponseR. </summary>
        public ModelEnvironmentDefinitionResponseR()
        {
        }

        /// <summary> Initializes a new instance of ModelEnvironmentDefinitionResponseR. </summary>
        /// <param name="rVersion"> The version of R to be installed. </param>
        /// <param name="userManaged"> Indicates whether the environment is managed by user or by AzureML. </param>
        /// <param name="rscriptPath">
        /// The Rscript path to use if an environment build is not required.
        /// 
        /// The path specified gets used to call the user script.
        /// </param>
        /// <param name="snapshotDate"> Date of MRAN snapshot to use in YYYY-MM-DD format, e.g. &quot;2019-04-17&quot;. </param>
        /// <param name="cranPackages"> The CRAN packages to use. </param>
        /// <param name="gitHubPackages"> The packages directly from GitHub. </param>
        /// <param name="customUrlPackages"> The packages from custom urls. </param>
        /// <param name="bioConductorPackages"> The packages from Bioconductor. </param>
        internal ModelEnvironmentDefinitionResponseR(string rVersion, bool? userManaged, string rscriptPath, string snapshotDate, IList<RCranPackage> cranPackages, IList<RGitHubPackageResponse> gitHubPackages, IList<string> customUrlPackages, IList<string> bioConductorPackages) : base(rVersion, userManaged, rscriptPath, snapshotDate, cranPackages, gitHubPackages, customUrlPackages, bioConductorPackages)
        {
        }
    }
}
