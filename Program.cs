using System;

namespace assignment_one
{
    public class program
    {
        public static void Main(string[] args)
        {  
            int dog_nights;
            string dog_stay;
            string dog_code;
            string dog_addon;

            Console.WriteLine("Would you like Additional Addon Services? Yes/No ");
            dog_addon = Console.ReadLine();

            Console.Write("Please Enter The number of days the dog is staying:  ");
            dog_stay = Console.ReadLine();
            dog_nights = Convert.ToInt32(dog_stay); 

            if (dog_addon == "Yes"){
                Console.WriteLine("Bathing And Grooming Code A: $169 Per Night | Bathing Only Code C: $112 Dollars Per Night ");
                Console.Write("Please Enter the Code you wish to Recieve: ( A | C ):   ");
                dog_code = Console.ReadLine();

                computeRate(dog_nights, dog_code);
            }else{
                computeRate(dog_nights);
            }
            
        }
        static void computeRate(int dog_nights, string dog_code){

            if (dog_code == "A"){
               double total = 169 * dog_nights;
               Console.WriteLine($"Your Total Estimated Amount is: {total.ToString("c")}");
            }else if (dog_code == "C"){
               double total = 112 * dog_nights;
               Console.WriteLine($"Your Total Estimated Amount is: {total.ToString("c")}");
            }else if (dog_code != "A" || dog_code != "C" ){
               Console.WriteLine("Your Total Estimated Amount is Invalid, Because Code Does Not exist, Sorry!");
            } 
            
        }

        static void computeRate(int dog_nights){
            double total = dog_nights * 75;
            Console.WriteLine($"Your Total Estimate Amount is: {total.ToString("c")}");
        }
    }
}

