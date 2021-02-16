using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public bool Add(Order order)
        {
            if(order.OrderPrice > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
