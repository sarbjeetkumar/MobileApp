using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ghostHunter
{
    public class GreenGhost
    {

        //Refrences 
        //https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.input.tappedeventhandler
        //https://msdn.microsoft.com/library/windows/apps/xaml/windows.ui.xaml.controls.image.source.aspx




        Image gGhost = new Image();
        private int taps;

        //constructor 
        public GreenGhost()
        {
            taps = 1;
            
            gGhost.Tapped += GGhost_Tapped;
        }

        private void GGhost_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            //throw new NotImplementedException();
            if (taps != 0)
            {
                //do something
                taps--;
                GamePage.score += 5;
            }
            if (taps == 0)
            {
                //create a diffrent image which shows ghost died 
                //call some method to change the image with death image
                getFinalKillImage();

            }
        }



        //create a method which return a image source to replace a image on the screen 
        public string getKillImage()
        {
            //absolutye path
            string imagePath = "ms-appx:///Data/ghostDied.png";
            return imagePath;


        }

        //Method to get a image path 
        public Image getFinalKillImage()
        {
            gGhost.Source = new BitmapImage(new Uri(getKillImage()));
            return gGhost;
        }




        //create a two methods set image and get image 
        //set image method will return a path to image and get image return a image .


        public String setImage()
        {
            //path variale 
            String getPath;

            getPath = "ms-appx:///Data/greenGhost.png";

            return getPath;
        }



        public Image getImage()
        {
            
            gGhost.Source = new BitmapImage(new Uri(setImage()));

            return gGhost;
        }

        

       



    }//class 
}
