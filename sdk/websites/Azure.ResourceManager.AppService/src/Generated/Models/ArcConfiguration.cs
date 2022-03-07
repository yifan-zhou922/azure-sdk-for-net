// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ArcConfiguration. </summary>
    public partial class ArcConfiguration
    {
        /// <summary> Initializes a new instance of ArcConfiguration. </summary>
        public ArcConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ArcConfiguration. </summary>
        /// <param name="artifactsStorageType"></param>
        /// <param name="artifactStorageClassName"></param>
        /// <param name="artifactStorageMountPath"></param>
        /// <param name="artifactStorageNodeName"></param>
        /// <param name="artifactStorageAccessMode"></param>
        /// <param name="frontEndServiceConfiguration"></param>
        /// <param name="kubeConfig"></param>
        internal ArcConfiguration(StorageType? artifactsStorageType, string artifactStorageClassName, string artifactStorageMountPath, string artifactStorageNodeName, string artifactStorageAccessMode, FrontEndConfiguration frontEndServiceConfiguration, string kubeConfig)
        {
            ArtifactsStorageType = artifactsStorageType;
            ArtifactStorageClassName = artifactStorageClassName;
            ArtifactStorageMountPath = artifactStorageMountPath;
            ArtifactStorageNodeName = artifactStorageNodeName;
            ArtifactStorageAccessMode = artifactStorageAccessMode;
            FrontEndServiceConfiguration = frontEndServiceConfiguration;
            KubeConfig = kubeConfig;
        }

        /// <summary> Gets or sets the artifacts storage type. </summary>
        public StorageType? ArtifactsStorageType { get; set; }
        /// <summary> Gets or sets the artifact storage class name. </summary>
        public string ArtifactStorageClassName { get; set; }
        /// <summary> Gets or sets the artifact storage mount path. </summary>
        public string ArtifactStorageMountPath { get; set; }
        /// <summary> Gets or sets the artifact storage node name. </summary>
        public string ArtifactStorageNodeName { get; set; }
        /// <summary> Gets or sets the artifact storage access mode. </summary>
        public string ArtifactStorageAccessMode { get; set; }
        /// <summary> Gets or sets the front end service configuration. </summary>
        internal FrontEndConfiguration FrontEndServiceConfiguration { get; set; }
        /// <summary> Gets or sets the front end service kind. </summary>
        public FrontEndServiceType? FrontEndServiceKind
        {
            get => FrontEndServiceConfiguration is null ? default : FrontEndServiceConfiguration.Kind;
            set
            {
                if (FrontEndServiceConfiguration is null)
                    FrontEndServiceConfiguration = new FrontEndConfiguration();
                FrontEndServiceConfiguration.Kind = value;
            }
        }

        /// <summary> Gets or sets the kube config. </summary>
        public string KubeConfig { get; set; }
    }
}
