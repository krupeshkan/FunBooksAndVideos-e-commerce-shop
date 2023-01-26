using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class PurchaseOrderGenerator : IPurchaseOrderGenerator
    {
        private readonly IPurchaseOrderGeneratorRepository _purchaseOrderGeneratorRepository;
        public PurchaseOrderGenerator(IPurchaseOrderGeneratorRepository purchaseOrderGeneratorRepository)
        {
            _purchaseOrderGeneratorRepository = purchaseOrderGeneratorRepository;
        }
        public bool Generate(Order order)
        {
          return  _purchaseOrderGeneratorRepository.SavePurchaseOrder(order);
        }
    }
}
