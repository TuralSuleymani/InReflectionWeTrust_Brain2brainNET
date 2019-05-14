using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderProtocol
{
   public interface IProvider
    {
        string Name { get; set; }
        void OnButtonClicked();
    }
}
