using System;

namespace JBandSons 
{
    class NetPay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______JB and Sons Consultants Ltd_______");
            Console.WriteLine();
            string userInput, staffID;
            char gender;
            int hoursWorked, regularHours = 40,overTime;
            double malePay = 500.00, femalePay = 550.00;
            double DTRate = 0.01, IncomeTaxRate = 0.15;
            double GrossPay = 0,NetPay,DistrictTax,NHCL,IncomeTax,OverTimePay = 0;
            float NHCLrate = 0.025F;
            double eduFund_M = 10.00, eduFund_F = 20.00, EduFund = 0;

            Console.Write("Enter your name: ");
            userInput = Console.ReadLine();

            Console.Write("Enter Staff ID: ");
            staffID = Console.ReadLine();

            Console.Write("Enter gender(M/F): ");
            gender = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter number of hours worked: ");
            string hoursInput = Console.ReadLine() ;
            hoursWorked = Convert.ToInt32(hoursInput);

            Console.Write("Enter number of childern: ");
            string childInput = Console.ReadLine() ;
            int child = Convert.ToInt32(childInput);

            
            if (gender == 'M' || gender == 'm')
            {
                if (hoursWorked <= regularHours)
                {
                    GrossPay = malePay * hoursWorked;
                    OverTimePay = 0;
                }
                else if (hoursWorked >= regularHours)
                {
                    overTime = hoursWorked - regularHours;
                    OverTimePay = 1.5 * malePay * overTime;
                    GrossPay = malePay * regularHours + OverTimePay;
                }
                
                if (child  > 3) 
                {
                    EduFund = eduFund_M * (child - 3);
                }
            }
            else if(gender == 'F' || gender == 'f')
            {
                if (hoursWorked <= regularHours)
                {
                    GrossPay = femalePay * hoursWorked;
                    //OverTimePay = 0;
                }
                else if (hoursWorked >= regularHours)
                {
                    overTime = hoursWorked - regularHours;
                    OverTimePay = 1.5 * femalePay * overTime;
                    GrossPay = femalePay * regularHours + OverTimePay;
                }

                if (child > 3)
                {
                    EduFund = eduFund_F * (child - 3);
                }

                /*IncomeTax = GrossPay * IncomeTaxRate;
                DistrictTax = DTRate * GrossPay;
                NHCL = NHCLrate * GrossPay;
                double deduction = IncomeTax + DistrictTax + NHCL + EduFund;*/
            }

            IncomeTax = GrossPay * IncomeTaxRate;
            DistrictTax = DTRate * GrossPay;
            NHCL = NHCLrate * GrossPay;
            double deduction = IncomeTax + DistrictTax + NHCL + EduFund;
            

            NetPay = GrossPay - deduction;

            Console.ReadLine();

            Console.WriteLine($"Name: {userInput}");
            Console.WriteLine($"Staff ID: {staffID}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Number of children: {child}");
            Console.WriteLine($"Gross Pay: {GrossPay:C}");
            Console.WriteLine($"Income Tax: {IncomeTax:C}, Distict Tax: {DistrictTax:C}, NHCL: {NHCL:C}, EduFund:{EduFund:C}"); 
            Console.WriteLine($"Deductions: {deduction:C}");
            Console.WriteLine($"Net Pay: {NetPay:C}");


            



        }
    }
}