namespace Stelmashok.ComputerComponents.Model
{
    public class Equipment
    {
        private Category category;

        private Firm firm;

        private Model model;

        private double price;

        public double Price
        {
            get
            {
                return this.price;
            }
        }

        public Model Model
        {
            get
            {
                return this.model;
            }
        }

        public Firm Firm
        {
            get
            {
                return this.firm;
            }
        }

        public Category Category
        {
            get
            {
                return this.category;
            }
        }
    }
}
