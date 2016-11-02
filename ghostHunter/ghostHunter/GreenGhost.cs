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
        //constructor 
        public GreenGhost()
        {

        }

        Image gGhost = new Image();


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

            /**
             * 
             *  greenSlime.Source = new BitmapImage(new Uri(getIcon(x)));
                    return greenSlime;
             * 
             * */
            gGhost.Source = new BitmapImage(new Uri(setImage()));

            return gGhost;
        }





    }//class 
}
