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
    /// APIServiceStatus contains derived information about an API server
    /// </summary>
    public partial class V1APIServiceStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1APIServiceStatus class.
        /// </summary>
        public V1APIServiceStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1APIServiceStatus class.
        /// </summary>
        /// <param name="conditions">
        /// Current service state of apiService.
        /// </param>
        public V1APIServiceStatus(IList<V1APIServiceCondition> conditions = null)
        {
            Conditions = conditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Current service state of apiService.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1APIServiceCondition> Conditions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
