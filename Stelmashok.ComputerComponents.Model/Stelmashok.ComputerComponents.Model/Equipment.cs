/// <summary>
/// The Model namespace.
/// </summary>
namespace Stelmashok.ComputerComponents.Model
{
    /// <summary>
    /// Class Equipment.
    /// </summary>
    public class Equipment : BaseClass
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public Model Model { get; set; }

        /// <summary>
        /// Gets or sets the firm.
        /// </summary>
        /// <value>The firm.</value>
        public Firm Firm { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public Category Category { get; set; }
    }
}
