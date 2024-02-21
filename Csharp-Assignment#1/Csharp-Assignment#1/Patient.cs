using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1 // Namespace declaration
{
    internal class Patient // Class declaration
    {
        // Properties
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public double Weight { get; set; } 
        public double Height { get; set; } 

        // Constructor
        public Patient(string firstName, string lastName, double weight, double height) // Constructor method declaration
        {
            FirstName = firstName; // Initializing first name property
            LastName = lastName; // Initializing last name property
            Weight = weight; // Initializing weight property
            Height = height; // Initializing height property
        }

        // Method to calculate blood pressure
        public string CalculateBloodPressure(int systolic, int diastolic) // Method to calculate blood pressure, takes systolic and diastolic values as parameters
        {
            if (systolic < 90 || systolic > 200 || diastolic < 60 || diastolic > 120) // Checking if blood pressure values are within valid range
            {
                return "Invalid blood pressure values. Please consult your doctor."; // Returning message for invalid blood pressure values
            }
            else if (systolic < 120 && diastolic < 80) // Checking for normal blood pressure range
            {
                return "NORMAL"; // Returning normal blood pressure status
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80) // Checking for elevated blood pressure range
            {
                return "ELEVATED"; // Returning elevated blood pressure status
            }
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89)) // Checking for stage 1 hypertension range
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1"; // Returning stage 1 hypertension status
            }
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120)) // Checking for stage 2 hypertension range
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2"; // Returning stage 2 hypertension status
            }
            else // Handling hypertensive crisis range
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)"; // Returning hypertensive crisis status
            }
        }

        // Method to calculate BMI
        public double CalculateBMI() // Method to calculate BMI
        {
            double heightInMeters = Height / 100; // Converting height to meters
            return Weight / (heightInMeters * heightInMeters); // Calculating and returning BMI
        }

        // Method to print patient information
        public void PrintPatientInformation(int systolic, int diastolic) // Method to print patient information, takes systolic and diastolic values as parameters
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}"); // Printing full name
            Console.WriteLine($"Weight: {Weight} KG"); // Printing weight
            Console.WriteLine($"Height: {Height} Centimeters"); // Printing height
            Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}"); // Printing calculated blood pressure
            double bmi = CalculateBMI(); // Calculating BMI
            Console.WriteLine($"BMI: {bmi}"); // Printing BMI
            if (bmi >= 25.0) // Checking BMI status for overweight
            {
                Console.WriteLine("BMI Status: Overweight"); // Printing BMI status as overweight
            }
            else if (bmi >= 18.5 && bmi <= 24.9) // Checking BMI status for normal range
            {
                Console.WriteLine("BMI Status: Normal (In the healthy range)"); // Printing BMI status as normal
            }
            else // Handling underweight BMI status
            {
                Console.WriteLine("BMI Status: Underweight"); // Printing BMI status as underweight
            }
        }

    }
}
