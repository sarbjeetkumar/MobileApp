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


        //constructor 
        public GreenGhost()
        {
            taps = 1;

        }

        Image gGhost = new Image();
        private int taps;



        //create a tap event to kill the ghost
        public void GreenGhost_Tap(Object sender , Windows.UI.Xaml.Input.TappedEventHandler e)
        {
            if (taps != 0)
            {
                //do something
            }
           if (taps == 0)
           {
                //create a diffrent image which shows ghost died 
                //call some method to change the image with death image 
           }
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

        

        //set image at random place 
        public void setImageAtRandomPlace(int placeOfImage)
        {
            
            

        }



    }//class 
}
