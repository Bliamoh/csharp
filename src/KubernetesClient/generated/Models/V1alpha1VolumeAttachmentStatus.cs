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
    /// VolumeAttachmentStatus is the status of a VolumeAttachment request.
    /// </summary>
    public partial class V1alpha1VolumeAttachmentStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1VolumeAttachmentStatus class.
        /// </summary>
        public V1alpha1VolumeAttachmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1VolumeAttachmentStatus class.
        /// </summary>
        /// <param name="attached">
        /// Indicates the volume is successfully attached. This field must only be set by
        /// the entity completing the attach operation, i.e. the external-attacher.
        /// </param>
        /// <param name="attachError">
        /// The last error encountered during attach operation, if any. This field must only
        /// be set by the entity completing the attach operation, i.e. the
        /// external-attacher.
        /// </param>
        /// <param name="attachmentMetadata">
        /// Upon successful attach, this field is populated with any information returned by
        /// the attach operation that must be passed into subsequent WaitForAttach or Mount
        /// calls. This field must only be set by the entity completing the attach
        /// operation, i.e. the external-attacher.
        /// </param>
        /// <param name="detachError">
        /// The last error encountered during detach operation, if any. This field must only
        /// be set by the entity completing the detach operation, i.e. the
        /// external-attacher.
        /// </param>
        public V1alpha1VolumeAttachmentStatus(bool attached, V1alpha1VolumeError attachError = null, IDictionary<string, string> attachmentMetadata = null, V1alpha1VolumeError detachError = null)
        {
            AttachError = attachError;
            Attached = attached;
            AttachmentMetadata = attachmentMetadata;
            DetachError = detachError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The last error encountered during attach operation, if any. This field must only
        /// be set by the entity completing the attach operation, i.e. the
        /// external-attacher.
        /// </summary>
        [JsonProperty(PropertyName = "attachError")]
        public V1alpha1VolumeError AttachError { get; set; }

        /// <summary>
        /// Indicates the volume is successfully attached. This field must only be set by
        /// the entity completing the attach operation, i.e. the external-attacher.
        /// </summary>
        [JsonProperty(PropertyName = "attached")]
        public bool Attached { get; set; }

        /// <summary>
        /// Upon successful attach, this field is populated with any information returned by
        /// the attach operation that must be passed into subsequent WaitForAttach or Mount
        /// calls. This field must only be set by the entity completing the attach
        /// operation, i.e. the external-attacher.
        /// </summary>
        [JsonProperty(PropertyName = "attachmentMetadata")]
        public IDictionary<string, string> AttachmentMetadata { get; set; }

        /// <summary>
        /// The last error encountered during detach operation, if any. This field must only
        /// be set by the entity completing the detach operation, i.e. the
        /// external-attacher.
        /// </summary>
        [JsonProperty(PropertyName = "detachError")]
        public V1alpha1VolumeError DetachError { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            AttachError?.Validate();
            DetachError?.Validate();
        }
    }
}
