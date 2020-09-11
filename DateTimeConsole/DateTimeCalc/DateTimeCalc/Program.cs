using System;
using System.Globalization;

namespace DateTimeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Date Time Calculator!");

            // 1 a
            //Addition logic
          /* Console.WriteLine("Enter the first date  in the format specified i.e MM/DD/YYYY");
            DateTime inputtedDate1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(inputtedDate1.ToString());
            Console.WriteLine("Enter the Second date  in the format specified i.e MM/DD/YYYY");
            DateTime inputtedDate2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(inputtedDate2.ToString());
            DateTime result1 = inputtedDate1.AddYears(inputtedDate2.Year);
            Console.WriteLine(result1.ToString());
            DateTime result4 = result1.AddMonths(inputtedDate2.Month);
            DateTime result5 = result4.AddDays(inputtedDate2.Day);
            Console.WriteLine("the final added date is " + result5.ToString());
          
            //1 b
            // Subtration Logic
            Console.WriteLine("For the Subtraction between the dates");
            Console.WriteLine("Enter the first date  in the format specified i.e MM/DD/YYYY");
            DateTime inputtedDate6 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(inputtedDate6.ToString());
            Console.WriteLine("Enter the Second date  in the format specified i.e MM/DD/YYYY");
            DateTime inputtedDate7 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(inputtedDate7.ToString());
            TimeSpan result6 = (TimeSpan)inputtedDate6.Subtract(inputtedDate7);
            Console.WriteLine("The subtratiobn result:"+result6.ToString());
            
            Console.WriteLine("The total Days:" + result6.TotalDays);


            /* Console.WriteLine(result1.ToString());
             DateTime result4 = result1.AddMonths(inputtedDate2.Month);
             DateTime result5 = result4.AddDays(inputtedDate2.Day);
             Console.WriteLine("the final added date is " + result5.ToString());
            */
            
            
            
            
            
            
            // Add, Subtract 'n' Days, Months, Weeks to the given date and derive the final date
           
            Console.WriteLine("Enter the date you want to modify in the specific format i.e yyyy - MM - DD");
           var inputtedDate8= DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
            Console.WriteLine(inputtedDate8.ToString());
            Console.WriteLine("Enter number of days to add");
            var numDay = int.Parse(Console.ReadLine());
            Console.WriteLine("The Final Date after days addition:" + inputtedDate8.AddDays(numDay));
            // Subtracting days
            Console.WriteLine("The Final Date after days subtraction:" + inputtedDate8.AddDays(-numDay));

            //Months alteration
            Console.WriteLine("Enter number of Months to add");
            var numMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("The Final Date after Month addition:" + inputtedDate8.AddMonths(numMonth));
            // Subtracting Months
            Console.WriteLine("The Final Date after Month subtraction:" + inputtedDate8.AddMonths(-numMonth));

            // Week Alteration
            Console.WriteLine("Enter number of Week to add");
            var numWeek = int.Parse(Console.ReadLine());
            Console.WriteLine("The Final Date after Week addition:" + inputtedDate8.AddDays(numWeek*7));
            // Subtracting Weeks
            Console.WriteLine("The Final Date after Week subtraction:" + inputtedDate8.AddDays(-(numWeek*7)));




            //Determine the Day of the Week for a given date
            Console.WriteLine("The Day is:" + " " + inputtedDate8.DayOfWeek);

            // Week number of the year
            Console.WriteLine("Enter Date");
            string date = Console.ReadLine();
            DateTime inputDate = DateTime.Parse(date.Trim());
            var d = inputDate;
            CultureInfo cul = CultureInfo.CurrentCulture;

            var firstDayWeek = cul.Calendar.GetWeekOfYear(d,CalendarWeekRule.FirstDay,DayOfWeek.Monday);

            int weekNum = cul.Calendar.GetWeekOfYear(d,CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            Console.WriteLine("The Week number is:" + " " + weekNum);













            //DateTime result2 = result1.AddMonths(inputtedDate2.Month);
            // DateTime result3 = result2.AddDays(inputtedDate2.Day);
            // Console.WriteLine(result3.ToString());
            // DateTime result = inputtedDate1.Add(inputtedDate2);
            //TimeSpan timespane = inputtedDate1 - inputtedDate2;
            // Console.WriteLine(result1.ToString());
            /*var datetime = new DateTime(2020, 09, 09);
             var now = DateTime.Now;
             var today = DateTime.Today;
             Console.WriteLine("Hour: " + now.Hour);
             Console.WriteLine("Minutes:" + now.Minute);
             var tomorrow = now.AddDays(1);
             var yesterday = now.AddDays(-1);
             Console.WriteLine(now.ToLongDateString());
             Console.WriteLine(now.ToShortDateString());
             Console.WriteLine(now.ToLongTimeString());
             Console.WriteLine(now.ToShortTimeString());
             Console.WriteLine(now.ToString("F"));
         */
        }
    }
}
