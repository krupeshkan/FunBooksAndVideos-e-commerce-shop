using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Repository.Classes
{
    public class OrderGenerateRepository : IOrderGenerateRepository
    {
        public bool GenerateOrder(Order order)
        {
            return true;
        }
    }
}
