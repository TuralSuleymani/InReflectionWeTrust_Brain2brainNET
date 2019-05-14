using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionAppUI.Core
{
   public class ProviderVisualizer
    {
        private readonly Control _control;
        private int _locationX = 20;
        private int _locationY = 34;

        public ProviderVisualizer(Control control)
        {
            _control = control;
        }
        public void AddProvider(IProvider provider)
        {
            Button button = new Button
            {
                Text = provider.Name,
                Size = new Size(150, 100),
                Location = new Point(_locationX, _locationY)
            };
            button.Click += (sndr, args) =>
            {
                provider.OnButtonClicked();
            };
            _locationX += 150;
            _control.Controls.Add(button);
        }
    }
}
