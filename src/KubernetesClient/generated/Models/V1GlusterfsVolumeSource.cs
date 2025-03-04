// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes
        /// do not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class V1GlusterfsVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1GlusterfsVolumeSource class.
        /// </summary>
        public V1GlusterfsVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1GlusterfsVolumeSource class.
        /// </summary>
        /// <param name="endpoints">
        /// EndpointsName is the endpoint name that details Glusterfs topology. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </param>
        /// <param name="path">
        /// Path is the Glusterfs volume path. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </param>
        /// <param name="readOnlyProperty">
        /// ReadOnly here will force the Glusterfs volume to be mounted with read-only
        /// permissions. Defaults to false. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </param>
        public V1GlusterfsVolumeSource(string endpoints, string path, bool? readOnlyProperty = null)
        {
            Endpoints = endpoints;
            Path = path;
            ReadOnlyProperty = readOnlyProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// EndpointsName is the endpoint name that details Glusterfs topology. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public string Endpoints { get; set; }

        /// <summary>
        /// Path is the Glusterfs volume path. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// ReadOnly here will force the Glusterfs volume to be mounted with read-only
        /// permissions. Defaults to false. More info:
        /// https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
