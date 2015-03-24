/// <summary>
/// The Model namespace.
/// </summary>
namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Client.
    /// </summary>
    public class Client : BaseClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client" /> class.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <value>The orders.</value>
        public List<Order> Orders { get; set; }
    }
}
