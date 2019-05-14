using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOfBank
{
    public class BankOfBakuProvider : IProvider
    {
        public string Name { get; set; } = "Bank Of Baku";

        public void OnButtonClicked()
        {
           //implementation simplified for learning..
            MessageBox.Show("This is Bank of Baku provider");
        }
    }
}
