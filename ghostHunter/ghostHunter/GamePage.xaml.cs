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
            createGhostOnGrid();
        }

        public static GreenGhost gGhost = new GreenGhost();
        public static RedGhost rGhost = new RedGhost();

        public static int score = 0;
        int maximumGhosts = 4;
        int minimumGhosts = 1;


       Random ran = new Random();
        //Steps
        /**
         * 
         * 1 Create a game class 
         * Create a rows and colunms in the grid
         * bring the picture at grid
         * bring the picture at random place 
         * create a tap event 
         * update a score if tapped 
         * and clear the grid and get another ghost on the grid 
         * and get a random ghosts from diffrent classes 
         * create a ghost on screen and clear it at y time 
         * set the timer to arrange the ghosts coming on the screen
         * now call that createGhostOnGrid() after every 2 seconds or set a timer
         * 
         * 
         * 
         */
        //get the random image first and


        //create a method which calls the create ghost method in y times and clear the grid 
        public void createGhostOnGrid()
        {

            //create a random number of enimes 
            int maxGhosts = ran.Next(minimumGhosts , maximumGhosts);

            //call the createGhost method and clear the grid before you create anythong on the grid
            gameGrid.Children.Clear();

            for (int j = 0; j<maxGhosts; j++)
            {
                createGhost();
            }

        }




        public void createGhost()
        {

            //create a random number first
            //take use that random number to select random picture
            //throw it on the grid

          

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
                        gGhost = new GreenGhost();
                    }
                    break;
                case 2:
                    if (randomNumber == 2)
                    {
                        //getFinalImage();
                        //gameGrid.Children.Add(ge.getImage());

                        gGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        gGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(gGhost.getImage());
                        gGhost = new GreenGhost();

                        /*
                        rGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        rGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(rGhost.getImage());*/
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


           

        }// method ends here 






    }//class
}
