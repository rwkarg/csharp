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
    /// A null or empty node selector term matches no objects. The requirements of them
        /// are ANDed. The TopologySelectorTerm type implements a subset of the
        /// NodeSelectorTerm.
    /// </summary>
    public partial class V1NodeSelectorTerm
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorTerm class.
        /// </summary>
        public V1NodeSelectorTerm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorTerm class.
        /// </summary>
        /// <param name="matchExpressions">
        /// A list of node selector requirements by node&apos;s labels.
        /// </param>
        /// <param name="matchFields">
        /// A list of node selector requirements by node&apos;s fields.
        /// </param>
        public V1NodeSelectorTerm(IList<V1NodeSelectorRequirement> matchExpressions = null, IList<V1NodeSelectorRequirement> matchFields = null)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// A list of node selector requirements by node&apos;s labels.
        /// </summary>
        [JsonProperty(PropertyName = "matchExpressions")]
        public IList<V1NodeSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>
        /// A list of node selector requirements by node&apos;s fields.
        /// </summary>
        [JsonProperty(PropertyName = "matchFields")]
        public IList<V1NodeSelectorRequirement> MatchFields { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MatchExpressions != null){
                foreach(var obj in MatchExpressions)
                {
                    obj.Validate();
                }
            }
            if (MatchFields != null){
                foreach(var obj in MatchFields)
                {
                    obj.Validate();
                }
            }
        }
    }
}
