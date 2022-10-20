using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using application.Entities;
using application.Interface;
using RabbitMQ.Client.Events;
using application.Infra;

namespace application.Service
{
    public class ProductService : IProductService
    {
        private readonly string _host = EnvConfig.ElastcHost();

        public ProductService()
        {
            
        }

        public int Generate(Productor request)
        {
            try
            {

                return 200;
            }
            catch (Exception)
            {

                return 404;
            }
        }


        public Productor Get(int? key)
        {
            throw new NotImplementedException();
        }
    }
}
