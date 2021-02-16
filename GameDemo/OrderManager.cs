using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void GetOrder(Order order)
        {
            if (_campaignService.Add(order))
            {
                Console.WriteLine("Order is taken");
            }
        }
    }
}
