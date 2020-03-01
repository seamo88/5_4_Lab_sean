using System;

namespace _5_4_Lab_sean
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }
            public int numberOfLives;
            public string currentlevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;
        }


        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.numberOfLives = 3;
            mario.currentlevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            //enter your code here.
            mario.isJumping = true;

            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            //enter your code here.
            mario.isJumping = false;

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            //enter your code here.
            mario.numberOfLives += 1;

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            //enter your code here.
            mario.canShootFireBalls = true;

            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            //enter your code here.
            mario.sizeOfMario = Mario.Size.large;

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            //enter your code here.
            mario.numOfCoins = 10;


            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            //enter your code here.
            mario.currentlevel = "World 1-2";



        }
    }
}
