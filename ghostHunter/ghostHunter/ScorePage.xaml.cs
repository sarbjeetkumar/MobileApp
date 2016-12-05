using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ghostHunter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScorePage : Page
    {

        //Refrences
        //https://msdn.microsoft.com/library/windows/apps/xaml/windows.storage.applicationdata.localsettings.aspx

        int value;

        
        //Create local Data Storage Container
        Windows.Storage.ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;



        public ScorePage()
        {
            this.InitializeComponent();
            //var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            //Object value = localSettings.Values["exampleSetting"];
            backButton.Tapped += BackButton_Tapped;
            finalScore.Text = GamePage.score.ToString() + localSettings.Values["saveScore"];
            checkAndSaveScore();


        }



        private void BackButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Frame.Navigate(typeof(MainPage));
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

       public void checkAndSaveScore()
        {
            if (localSettings.Values["savedScore"] == null)
            {
                localSettings.Values["savedScore"] = "0";
            }

            value = Int32.Parse(localSettings.Values["savedScore"].ToString());


            if (value < GamePage.score)
            {
                localSettings.Values["savedScore"] = GamePage.score.ToString();
            }
        }



       
    }
}
