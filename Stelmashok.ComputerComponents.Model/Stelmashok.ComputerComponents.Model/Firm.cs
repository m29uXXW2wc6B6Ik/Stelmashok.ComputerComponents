// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Firm.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Firm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Stelmashok.ComputerComponents.Model
{
    using System.Collections.Generic;

    public class Firm
    {
        private List<Model> models;

        public string Name { get; set; }

        public List<Model> Models
        {
            get
            {
                return this.models;
            }
        }
    }
}
