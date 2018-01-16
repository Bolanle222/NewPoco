using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poco;


namespace InMemoryBrokers
{
  
    public class InMemoryBrokerRepository : IBrokerRepository
    {
        List<broker> brokers = new List<broker>();
        

        public List<broker> GetAllBrokers()
        {
           // return null;
            return brokers;
        }

        public broker GetBrokerById(int broker_id)
        {
            var broker = brokers.FirstOrDefault(b => b.broker_id == broker_id);
            return broker;
        }
    }

}
