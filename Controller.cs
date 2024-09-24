using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Repository
{
    public class controller
    {
        private readonly IRepository<controller> _repor;

        public controller(IRepository<controller> repor)
        {
            _repor = repor;
        }
    }
}
