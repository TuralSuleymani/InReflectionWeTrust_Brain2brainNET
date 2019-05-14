using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ReflectionAppUI.Core;
using System.Reflection;
using ProviderProtocol;

namespace ReflectionAppUI
{
    public partial class MainForm : Form
    {
        ProviderVisualizer _providerVisualizer;
        public MainForm()
        {
            InitializeComponent();
            _providerVisualizer = new ProviderVisualizer(grbx_providers);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get path to libs folder
            string libsPath = ApplicationPath.PathTo("libs");
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

                        _providerVisualizer.AddProvider(prvdr);
                    }
                } 
            }

        }
    }
}
