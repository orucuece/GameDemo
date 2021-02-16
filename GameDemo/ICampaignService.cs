using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaignService
    {
        bool Add(Order order);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
