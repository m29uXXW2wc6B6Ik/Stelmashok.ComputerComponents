/// <summary>
/// The Model namespace.
/// </summary>
namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Model.
    /// </summary>
    public class Model : BaseClass
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the firms.
        /// </summary>
        /// <value>The firms.</value>
        public List<Firm> Firms { get; set; }
    }
}
