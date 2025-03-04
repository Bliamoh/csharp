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
    /// PodsMetricStatus indicates the current value of a metric describing each pod in
        /// the current scale target (for example, transactions-processed-per-second).
    /// </summary>
    public partial class V2beta2PodsMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2beta2PodsMetricStatus class.
        /// </summary>
        public V2beta2PodsMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta2PodsMetricStatus class.
        /// </summary>
        /// <param name="current">
        /// current contains the current value for the given metric
        /// </param>
        /// <param name="metric">
        /// metric identifies the target metric by name and selector
        /// </param>
        public V2beta2PodsMetricStatus(V2beta2MetricValueStatus current, V2beta2MetricIdentifier metric)
        {
            Current = current;
            Metric = metric;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// current contains the current value for the given metric
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public V2beta2MetricValueStatus Current { get; set; }

        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public V2beta2MetricIdentifier Metric { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Current == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Current");    
            }
            if (Metric == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metric");    
            }
            Current?.Validate();
            Metric?.Validate();
        }
    }
}
