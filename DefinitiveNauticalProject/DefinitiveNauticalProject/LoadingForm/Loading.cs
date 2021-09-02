using DefinitiveNauticalProject.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DefinitiveNauticalProject.LoadingForm
{
    public partial class Loading : Form
    {
        /*private field*/
        private static Loading loading;
        
            /*Builder*/
        public Loading()
        {
            InitializeComponent();
            this.pictureBox.Image = Properties.Resources.loading_icon_transparent_background_12_jpg;
            
        }

        /*Methods to create a loading screen*/

        /*This method prepare to launch the loading screen using a private trhead*/
        private delegate void CloseDelegate();

        /*----------------------------------------Show the loading screen methods------------------------------*/
        static public void ShowLoading()
        {
            /*protection in case of multiple launch*/ 
            if (loading != null) return;
            loading = new Loading();
            Thread thread = new Thread(new ThreadStart(Loading.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (loading != null)
            {
                Application.Run(loading);
            }
        }

        /*----------------------------------------Close the loading screen methods------------------------------*/

        static public void CloseLoading()
        {
            loading?.Invoke(new CloseDelegate(Loading.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (loading != null)
            {
                loading.Close();
                loading = null;
            }
        }

    }
}
