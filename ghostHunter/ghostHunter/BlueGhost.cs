using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ghostHunter
{
     public class BlueGhost
    {

        Image bGhost = new Image();
        private int taps;

        //constructor 
        public BlueGhost()
        {
            taps = 1;

            bGhost.Tapped += BGhost_Tapped;
        }

        private void BGhost_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
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
            bGhost.Source = new BitmapImage(new Uri(getKillImage()));
            return bGhost;
        }




        //create a two methods set image and get image 
        //set image method will return a path to image and get image return a image .


        public String setImage()
        {
            //path variale 
            String getPath;

            getPath = "ms-appx:///Data/blueGhost2.png";

            return getPath;
        }



        public Image getImage()
        {

            bGhost.Source = new BitmapImage(new Uri(setImage()));

            return bGhost;
        }



       

    }
}
