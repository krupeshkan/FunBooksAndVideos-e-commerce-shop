using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class ShippingSlipGenerator : IShippingSlipGenerator
    {
        public bool Generate(Order order)
        {
            if (order.ItemLines.Any(a => a is IPhysicalProduct))
            {
                return true;
            }

            return default(bool);
        }
    }
}
