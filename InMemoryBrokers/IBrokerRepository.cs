using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poco;

namespace InMemoryBrokers
{
   
public interface IBrokerRepository
    {
        List<broker> GetAllBrokers();
        broker GetBrokerById(int broker_id);
    }


}
