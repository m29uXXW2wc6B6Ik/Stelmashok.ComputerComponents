/// <summary>
/// The Model namespace.
/// </summary>
namespace Stelmashok.ComputerComponents.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Order.
    /// </summary>
    public class Order : BaseClass
    {
        /// <summary>
        /// Gets or sets the equipments.
        /// </summary>
        /// <value>The equipments.</value>
        public List<Equipment> Equipments { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the sum price.
        /// </summary>
        /// <value>The sum price.</value>
        public double SumPrice { get; set; }
    }
}
