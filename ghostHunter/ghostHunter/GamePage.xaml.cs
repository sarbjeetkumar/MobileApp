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
using System.Threading;
using Windows.UI.Popups;
using Windows.ApplicationModel.Core;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
//refrence 
//https://msdn.microsoft.com/en-us/library/system.windows.threading.dispatcher(v=vs.110).aspx

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
            //createGhostOnGrid();
            
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(recallTimer);
            Timer.Tick += Timer_Tick;
            startGame();
        }

        public void startGame()
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            callCreateGhost();
            init();
            //throw new NotImplementedException();

        }

        

        public static GreenGhost gGhost = new GreenGhost();
        public static RedGhost rGhost = new RedGhost();
        public static BlueGhost bGhost = new BlueGhost();
        public static WhiteGhost wGhost = new WhiteGhost();


        // variables 

        public static int score = 0;
        int maximumGhosts = 3;
        int minimumGhosts = 1;
        private DispatcherTimer Timer;
        double recallTimer = 5000; //seconds 
        public static int waitTime = 2;
        public static int countGhosts = 0;
        int minScore = 30;
       

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
         * now call that createGhostOnGrid() after every 2 seconds or set a timer and clear the grid as well
         * create a score counter to end the game 
         * 
         * 
         * 
         */
        

        //init method check score and set min and max ghosts on the screen  
        public  void init()
        {
            //check score and do changes in game
            //check for how many user missed 
            //decide to continue or game over 

            if(score == 30)
            {
                minimumGhosts = 2;
                maximumGhosts = 4;
                
            }

            if(score == 50)
            {
                minimumGhosts = 3;
                maximumGhosts = 5;
            }


            else if (countGhosts > 30 && score < 50)
            {
                //do something  
                Timer.Stop();


                this.Frame.Navigate(typeof(ScorePage));


            }

            else if (countGhosts > 40 && score < 80)
            {
                //do something  
                Timer.Stop();


                this.Frame.Navigate(typeof(ScorePage));


            }


        }

        //create a method to call createGhostOngrid method after every x(Some 2 seconds ) time
        public async void callCreateGhost()
        {
           
            for (int j = 0; j<3;j++) { 
                    
                createGhostOnGrid();
                await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(waitTime));

            }

            updateScore();
            updateStage();


        }


        //create a method which calls the create ghost method in y times and clear the grid 
        public void createGhostOnGrid()
        {

            //create a random number of enimes 
            int maxGhosts = ran.Next(minimumGhosts , maximumGhosts);

            //call the createGhost method and clear the grid before you create anythong on the grid
           
           gameGrid.Children.Clear();

            for (int j = 1; j<maxGhosts; j++)
            {
                createGhost();
                System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(2));


            }

        }//ends here 

        //counting how many ghost appearing on the screen
        public void ghostcount()
        {

            countGhosts = countGhosts + 1;
            //tblLife.Text = "Remaning Life  " + countGhosts.ToString();

        }
        

        //create a ghost on the screen 
        public void createGhost()
        {
            ghostcount();

           
             int randomNumber =  ran.Next(0 , 5);

            int randomX = ran.Next(1 , 6);
            int randomY = ran.Next(1, 6);

            
            switch (randomNumber)
            {
                
                //if number 1 select Green Ghost Class 
                case 1:
                    if (randomNumber == 1)
                    {

                        gGhost.getImage().SetValue(Grid.RowProperty,randomX);
                        gGhost.getImage().SetValue(Grid.ColumnProperty,randomY);
                        gameGrid.Children.Add(gGhost.getImage());
                        gGhost = new GreenGhost();


                    }
                    break;
                case 2:
                    //if number 2 select BlueGhost
                    if (randomNumber == 2)
                    {

                        bGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        bGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(bGhost.getImage());
                        bGhost = new BlueGhost();



                    }
                    break;
                    //if number 3 select red ghost 
                case 3:
                    if (randomNumber == 3)
                    {

                        bGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        bGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(rGhost.getImage());
                        rGhost = new RedGhost();



                    }
                    break;
                    //if number 4 select white ghost
                case 4:
                    if (randomNumber == 4)
                    {

                        bGhost.getImage().SetValue(Grid.RowProperty, randomX);
                        bGhost.getImage().SetValue(Grid.ColumnProperty, randomY);
                        gameGrid.Children.Add(wGhost.getImage());
                        wGhost = new WhiteGhost();



                    }
                    break;

            }//switch ends here

           

        }// method ends here 





        //update the score and put it on text boz
        public void updateScore()
        {
            tblScore.Text = "Score " + score.ToString(); 

        }





        //update the stage 
        public void updateStage()
        {
            //do some stuff to update the score 
            //tblStage.Text = ""+  
            int stage = 1;
            tblStage.Text = "Stage " + stage.ToString();
            
            if (score == 25)
            {
                stage = 1;
                tblStage.Text = "Stage " + stage.ToString();
            }
            if (score > 30 )
            {
                stage = 2;
                tblStage.Text = "Stage " + stage.ToString();
            }
            if (score > 50)
            {
                stage = 3;
                tblStage.Text = "Stage " + stage.ToString();
            }
            if (score > 80)
            {
                stage = 4;
                tblStage.Text = "Stage " + stage.ToString();
            }
        }


    }//class
}
