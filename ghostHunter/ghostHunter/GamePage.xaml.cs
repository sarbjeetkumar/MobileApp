using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();
            createImage();
        }


        //GamePage ge;

        public static GreenGhost gGhost = new GreenGhost();
        public static RedGhost rGhost = new RedGhost();

        //get the random image first and
        public void createImage()
        {

            //create a random number first
            //take use that random number to select random picture
            //throw it on the grid

            Random ran = new Random();

             int randomNumber =  ran.Next(1 , 2);

            int randomX = ran.Next(0 , 6);
            int randomY = ran.Next(0, 6);


            switch (randomNumber)
            {
                case 1:
                    if (randomNumber == 1)
                    {
                        //gameGrid.Children.Add(ge.getImage());
                        gGhost.getImage().SetValue(Grid.RowProperty,randomX);
                        gGhost.getImage().SetValue(Grid.ColumnProperty,randomY);
                        gameGrid.Children.Add(gGhost.getImage());
                    }
                    break;
                case 2:
                    if (randomNumber == 2)
                    {
                        //getFinalImage();
                        //gameGrid.Children.Add(ge.getImage());
                        rGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        rGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(rGhost.getImage());
                    }
                    break;
               /* case 3:
                    if (randomNumber == 3)
                    {
                        //call the ghost
                        // getFinalImage();
                        gameGrid.Children.Add(ge.getImage());
                    }
                    break;
                case 4:
                    if (randomNumber == 4)
                    {
                        //call the ghost 
                        // getFinalImage();
                       
                        gameGrid.Children.Add(ge.getImage().SetValue(Grid.ColumnProperty, place));
                    }
                    break;*/
            }


            /**
             * 
             *  es.getImage().SetValue(Grid.RowProperty, y);
                es.getImage().SetValue(Grid.ColumnProperty, x);
                 //add Slime to the grid
                 grdGame.Children.Add(es.getImage(x));
             * 
             * 
             * */


        }// method ends here 






    }//class
}
