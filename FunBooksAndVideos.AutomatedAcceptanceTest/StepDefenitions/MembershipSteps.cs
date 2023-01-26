using FunBooksAndVideos.BusinessLogic.Classes;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using FunBooksAndVideos.Repository.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FunBooksAndVideos.AutomatedAcceptanceTest.StepDefenitions
{
   [Binding]
    public class MembershipSteps
    {
        private Order _order;

        [BeforeScenario]
        public void Setup()
        {
            _order = new Order(); 
        }
        public void GivenTheUseHasPlacedTheOrderWithBookMembership(Table table)
        {
            var customer = table.CreateInstance<Customer>();

            _order.Customer = new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName
            };
        }

        public void GivenLineOfItems(Table table)
        {
            int productId = Convert.ToInt32(table.Rows[0]["ProductID"]);
            string productName = table.Rows[0]["ProductName"];

            INonPhysicalProduct membership = MembershipFactory.CreateMembership(productName);
            membership.ProductId = productId;
            membership.ProductName = productName;


            _order.ItemLines = new List<IProduct>
            {
                membership
            };
            
        }

       
        public void WhenIProcessTheOrderWithBookMembership()
        {
            BookMembershipActivator bookMembershipActivator = new BookMembershipActivator(null, new MembershipActivateRepository());

            var actual = bookMembershipActivator.Activate(_order);

            ScenarioContext.Current.Add("BookMembership", actual);
        }


        public void ThenBookMembershipShouldBeActivated()
        {
            var actual = ScenarioContext.Current.Get<bool>("BookMembership");

            Assert.IsTrue(actual);
        }


        public void WhenIProcessTheOrderWithVideoMembership()
        {
            VideoMembershipActivator videoMembershipActivator = new VideoMembershipActivator(null, new MembershipActivateRepository());

            var actual = videoMembershipActivator.Activate(_order);

            ScenarioContext.Current.Add("VideoMembership", actual);
        }

        public void ThenVideoMembershipShouldBeActivated()
        {
            var actual = ScenarioContext.Current.Get<bool>("VideoMembership");

            Assert.IsTrue(actual);
        }

    }
}
