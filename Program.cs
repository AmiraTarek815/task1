namespace ConsoleApp1
{
    internal class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Assignment Score (0,100) : ");
            double Assignment = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mid_term Score (0,100) : ");
            double Mid_term = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Final_exam Score (0,100) : ");
            double Final_exam = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class_participation Score (0,100) : ");
            double Class_participation = double.Parse(Console.ReadLine());
            double Total_Score=Assignment*.3+Mid_term*.25+Final_exam * .35 + Class_participation * .1;
            char grade;
            if (Total_Score >= 90) grade = 'A';
            else if (Total_Score >= 80) grade = 'B';
            else if (Total_Score >= 70) grade = 'C';
            else  grade = 'D';
            Console.WriteLine("Grade = " + grade);
            string subcategory = "";
            if (grade == 'A')
            {
                if (Total_Score >= 97) subcategory = "Outstanding";
                else if (Total_Score >= 93) subcategory = "Excellent";
                else subcategory = "Graet";
            }
            else if (grade == 'B')
            {
                if (Total_Score >= 87) subcategory = "Very good";
                else if (Total_Score >= 83) subcategory = "Good";
                else subcategory = "Satisfactory";
            }
            else if (grade == 'C')
            {
                if (Total_Score >= 77) subcategory = "Average +";
                else if (Total_Score >= 73) subcategory = "Average";
                else subcategory = "Below average";
            }
            Console.WriteLine("subcategory = " + subcategory);
            if (Assignment  < 60 && Final_exam >= 85)
                Console.WriteLine("Low assignment score but great job on the final exam");
            if (Assignment  >= 90 && Final_exam < 70)
                Console.WriteLine("strong assignment score but focus more on the final exam");
            double improvement = Final_exam - Mid_term;
            Console.WriteLine("imprevement = " + improvement);

        }
    }
}
