using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ghostHunter
{
    public class RedGhost
    {

        //constructor 
        public RedGhost()
        {

        }

        Image RGhost = new Image();


        //create methods set image and get image 
        //set image method will return a path to image and get image return a image .


        public String setImage()
        {
            //path variale 
            String getPath;

            getPath = "ms-appx:///Data/redGhost.png";

            return getPath;
        }



        public Image getImage()
        {

            RGhost.Source = new BitmapImage(new Uri(setImage()));

            return RGhost;
        }



        //set image at random place 
        public void setImageAtRandomPlace(int placeOfImage)
        {



        }






    }//class 
}
