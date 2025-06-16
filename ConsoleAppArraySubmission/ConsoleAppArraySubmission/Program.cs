namespace ConsoleAppArraySubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This bock of code creates an array and adds 6 names to the array
            string[] namesArray = new string[6];
            namesArray[0] = "Emily";
            namesArray[1] = "Jake";
            namesArray[2] = "Ashley";
            namesArray[3] = "Brandon";
            namesArray[4] = "Madison";
            namesArray[5] = "Tomas";

            while (true)
            {
                Console.WriteLine("\nSelect an index of the Array of names. (0 - 5):");
                short namesArrayIndex = Convert.ToInt16(Console.ReadLine()); //Converts entered data to short data type

                //This block of code checks if the user enterd existing index and
                //prints the value contained under this index.
                if (namesArrayIndex > 0 && namesArrayIndex <= 5)
                {
                    Console.WriteLine(namesArray[namesArrayIndex]);
                    break;
                }

                //Prints the error message when the user selects an index that doesn’t exist
                Console.WriteLine("\nEntered index doesn't exist. Select an index from 0 to 5.");
            }

            //Creates an array with inteders
            int[] intArray = { 8, 20, 64, 11, 77, 41, 78, 88, 13, 0, 55 };
            while (true)
            {
                Console.WriteLine("\nSelect an index of the Array of names. 0 - 10:");
                short intArrayIndex = Convert.ToInt16(Console.ReadLine()); //Converts entered data to short data type

                //This block of code checks if the user enterd existing index and
                //prints the value contained under this index.
                if (intArrayIndex > 0 && intArrayIndex <= 10)
                {
                    Console.WriteLine(intArray[intArrayIndex]);
                    break;
                }

                //Prints the error message when the user selects an index that doesn’t exist
                Console.WriteLine("\nEntered index doesn't exist. Select an index from 0 to 10.");

            }


            List<string> cars = new List<string>() { "Ford", "Toyota", "Chevrolet", "Honda", "BMW" };
            while (true)
            {
                Console.WriteLine("\nSelect an index of the Array of names. (0 - 4):");
                short carsIndex = Convert.ToInt16(Console.ReadLine());

                //This block of code checks if the user enterd existing index and
                //prints the value contained under this index.
                if (carsIndex > 0 && carsIndex <= 4)
                {
                    Console.WriteLine(cars[carsIndex]);
                    break;
                }

                //Prints the error message when the user selects an index that doesn’t exist
                Console.WriteLine("\nEntered index doesn't exist. Select an index from 0 to 4.");
            }

        }
    }
}
