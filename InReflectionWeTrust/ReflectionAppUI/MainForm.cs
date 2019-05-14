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
            _providerVisualizer.LoadFrom(libsPath);

        }

        private void btn_relaod_Click(object sender, EventArgs e)
        {
            _providerVisualizer.ClearProviders();
            _providerVisualizer.LoadFrom(ApplicationPath.PathTo("libs"));
        }
    }
}
