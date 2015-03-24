/// <summary>
/// The Model namespace.
/// </summary>
namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Firm.
    /// </summary>
    public class Firm : BaseClass
    {
        /// <summary>
        /// The models
        /// </summary>
        private List<Model> models;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the models.
        /// </summary>
        /// <value>The models.</value>
        public List<Model> Models { get; set; }
    }
}
