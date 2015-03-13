namespace Stelmashok.ComputerComponents.Model
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        private List<Equipment> equipments;

        private double sumPrice;

        private DateTime date;

        public Order()
        {
            this.equipments = new List<Equipment>();
            sumPrice = 0;
            date = DateTime.Now;
        }

        public List<Equipment> Equipments
        {
            get
            {
                return this.equipments;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public double SumPrice
        {
            get
            {
                return this.sumPrice;
            }
        }
    }
}
