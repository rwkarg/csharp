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
    /// AggregationRule describes how to locate ClusterRoles to aggregate into the
        /// ClusterRole
    /// </summary>
    public partial class V1AggregationRule
    {
        /// <summary>
        /// Initializes a new instance of the V1AggregationRule class.
        /// </summary>
        public V1AggregationRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1AggregationRule class.
        /// </summary>
        /// <param name="clusterRoleSelectors">
        /// ClusterRoleSelectors holds a list of selectors which will be used to find
        /// ClusterRoles and create the rules. If any of the selectors match, then the
        /// ClusterRole&apos;s permissions will be added
        /// </param>
        public V1AggregationRule(IList<V1LabelSelector> clusterRoleSelectors = null)
        {
            ClusterRoleSelectors = clusterRoleSelectors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// ClusterRoleSelectors holds a list of selectors which will be used to find
        /// ClusterRoles and create the rules. If any of the selectors match, then the
        /// ClusterRole&apos;s permissions will be added
        /// </summary>
        [JsonProperty(PropertyName = "clusterRoleSelectors")]
        public IList<V1LabelSelector> ClusterRoleSelectors { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClusterRoleSelectors != null){
                foreach(var obj in ClusterRoleSelectors)
                {
                    obj.Validate();
                }
            }
        }
    }
}
