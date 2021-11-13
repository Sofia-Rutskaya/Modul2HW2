using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class ConfigService
    {
        private Config _config;

        public ConfigService()
        {
            _config = new Config();
        }

        public int GetBusketSize()
        {
            return _config.BasketOfUser;
        }

        public Currency GetCurrency()
        {
             return _config.Currenc;
        }
    }
}
