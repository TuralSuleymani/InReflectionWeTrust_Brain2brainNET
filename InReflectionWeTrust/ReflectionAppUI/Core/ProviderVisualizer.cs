using ProviderProtocol;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionAppUI.Core
{
   public class ProviderVisualizer
    {
        private readonly Control _control;
        private int _locationX ;
        private int _locationY ;

        public ProviderVisualizer(Control control)
        {
            _control = control;
            InitializeDefaultParams();
        }

        public void ClearProviders()
        {
            _control.Controls.Clear();
            InitializeDefaultParams();
        }

        private void InitializeDefaultParams()
        {
            _locationX = 20;
            _locationY = 34;
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

        public void LoadFrom(string path)
        {
            //get path to libs folder
            string libsPath = path;
            //get only dll files
            string[] providers = Directory.GetFiles(libsPath, "*.dll");

            //for simplicity excaped LINQ query...
            //for every provider ....
            foreach (string provider in providers)
            {
                //load it into application RAM..
                Assembly assembly = Assembly.LoadFile(provider);

                //get all types in assembly
                Type[] assemblyTypes = assembly.GetTypes();

                foreach (Type assemblyType in assemblyTypes)
                {

                    Type type = assemblyType.GetInterface("IProvider", true);

                    //if current type implemented IProvider interface then..
                    if (type != null)
                    {
                        //create instance of class at runtime
                        IProvider prvdr = (IProvider)Activator.CreateInstance(assemblyType);

                        this.AddProvider(prvdr);
                    }
                }
            }
        }
    }
}
