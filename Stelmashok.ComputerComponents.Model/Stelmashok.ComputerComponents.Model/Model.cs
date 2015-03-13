namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    public class Model
    {
        private List<Firm> firms;

        public string Name { get; set; }

        public List<Firm> Firms
        {
            get
            {
                return this.firms;
            }
        }
    }
}
