using System;

namespace _2018_B4_ADS_Course_Project
{
    class Program
    {
        static int userInteractionValue;
        
        static void Main(string[] args)
        {
            userInteractionValue = -1;
            HandleInteraction();
        }

        static void DrawCLIInterface(){
            Console.WriteLine("======= Applied Data Structure Course Project =======");
            Console.WriteLine("-:-:-: Menu Options :-:-:-");
            Console.WriteLine("–: Press 1 to Read Data from File and Store in BookDataStructure");
            Console.WriteLine("–: Press 2 to Create Book Piles");
            Console.WriteLine("–: Press 3 to Show Book Piles");
            Console.WriteLine("–: Press 4 to Save Book in Database");
            Console.WriteLine("–: Press 0 to Exit Application");
            Console.WriteLine("-:-:-: Menu End :-:-:-");
            Console.Write("Enter Menu Number: ");
        }

        static void HandleInteraction(){
            while(true){
                DrawCLIInterface();
                String userResponse = Console.ReadLine();
                if(Int32.TryParse(userResponse, out userInteractionValue)){
                    switch(userInteractionValue){
                        case 1:
                            // Read Data From Text CSV file and saving data in data structure
                            break;
                        case 2:
                            // Create Book Piles
                            break;
                        case 3:
                            // Show Book Piles
                            break;
                        case 4:
                            // Save Books in Database
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Not_A_Menu_Number: Please give menu number between 0 to 4");
                            break;
                    }
                } else {
                    Console.WriteLine("Not_Integer: Please give menu number between 0 to 4");
                }
            }
        }
    }
}
