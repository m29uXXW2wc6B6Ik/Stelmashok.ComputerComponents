// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Client type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    public class Client
    {
        private List<Order> orders;

        public Client()
        {
            this.orders = new List<Order>();
        }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public List<Order> Orders
        {
            get
            {
                return this.orders;
            }
        }
    }
}
