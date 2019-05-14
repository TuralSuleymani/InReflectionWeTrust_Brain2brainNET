using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeInternetProvider
{
    public class FakeInternetProvider : IProvider
    {
        public string Name { get; set; } = "Fake Internet Provider";

        public void OnButtonClicked()
        {
            MessageBox.Show("This is fake provider");
        }
    }
}
