using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IPurchaseOrderGenerator _purchaseOrderGenerator;
        private readonly IShippingSlipGenerator _shippingSlipGenerator;
        private readonly IMembershipActivator _memberShipActivator;

        public OrderProcessor(IPurchaseOrderGenerator purchaseOrderGenerator, IShippingSlipGenerator shippingSlipGenerator, IMembershipActivator memberShipActivator)
        {
            _purchaseOrderGenerator = purchaseOrderGenerator;
            _shippingSlipGenerator = shippingSlipGenerator;
            _memberShipActivator = memberShipActivator;
        }

        public void ProcessOrder(Order order)
        {
            try
            {

                _memberShipActivator.Activate(order);

                _purchaseOrderGenerator.Generate(order);

                _shippingSlipGenerator.Generate(order);

            }
            catch
            {
                throw;
            }
        }
    }
}
