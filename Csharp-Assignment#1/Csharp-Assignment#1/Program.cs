namespace Csharp_Assignment_1 // Namespace declaration
{
    internal class Program // Class declaration
    {
        static void Main(string[] args) // Main method declaration
        {
            string firstName, lastName;
            double weight, height;
            int systolic, diastolic;

            Console.WriteLine("Enter patient's first name:"); // Prompting user to enter patient's first name
            firstName = Console.ReadLine(); // Reading patient's first name input from console

            Console.WriteLine("Enter patient's last name:"); // Prompting user to enter patient's last name
            lastName = Console.ReadLine(); // Reading patient's last name input from console

            // Handling weight input
            bool validWeight = false;
            do
            {
                Console.WriteLine("Enter patient's weight in KG:");
                string weightInput = Console.ReadLine();
                if (double.TryParse(weightInput, out weight))
                {
                    validWeight = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid weight.");
                }
            } while (!validWeight);

            // Handling height input
            bool validHeight = false;
            do
            {
                Console.WriteLine("Enter patient's height in Centimeters:");
                string heightInput = Console.ReadLine();
                if (double.TryParse(heightInput, out height))
                {
                    validHeight = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid height.");
                }
            } while (!validHeight);

            // Handling systolic blood pressure input
            bool validSystolic = false;
            do
            {
                Console.WriteLine("Enter patient's systolic blood pressure:");
                string systolicInput = Console.ReadLine();
                if (int.TryParse(systolicInput, out systolic))
                {
                    validSystolic = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid systolic blood pressure.");
                }
            } while (!validSystolic);

            // Handling diastolic blood pressure input
            bool validDiastolic = false;
            do
            {
                Console.WriteLine("Enter patient's diastolic blood pressure:");
                string diastolicInput = Console.ReadLine();
                if (int.TryParse(diastolicInput, out diastolic))
                {
                    validDiastolic = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid diastolic blood pressure.");
                }
            } while (!validDiastolic);

            Patient patient = new Patient(firstName, lastName, weight, height); // Creating a new Patient object with provided information
            patient.PrintPatientInformation(systolic, diastolic); // Calling the method to print patient information with blood pressure readings

            Console.ReadLine(); // Keeping the console window open until a key is pressed
        }
    }
}
