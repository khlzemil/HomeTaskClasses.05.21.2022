using System;

class HomeWork
{

    public static void Main()
    {

        Student student1 = new Student
        {
            HomeWorkGrades = new int[] {95,95,95,100,100},
            ProjectGrades =new int[] {85,80,90},
            FinalGrade = 94,
            Davamiyyet =new bool[] {true, true, false, true ,true}
        };

        student1.AvaragePointCounter(90, 80);
    }

}

class Student
{
        public int[] HomeWorkGrades;
        public int[] ProjectGrades;
        public int FinalGrade;
        public bool[] Davamiyyet;

    public void AvaragePointCounter(int GradePointForHighHonour, int GradePointForHonour)
    {
        int countTrue = 0;
        int countFalse = 0;
        int hwgCounter = 0;
        int hwgSum = 0;
        int pgCounter = 0;
        int pgSum = 0;
        foreach(var  missing in Davamiyyet)
        {
           if(missing == true)
            {
                countTrue++;
            }
            else
            {
                countFalse++;
            }
        }

        

        foreach(int hwg in HomeWorkGrades)
        {
            hwgSum += hwg;
            hwgCounter++;
        }
        int avarageHomeWorkGrades = hwgSum / hwgCounter;

        foreach (int pg in ProjectGrades)
        {
            pgSum += pg;
            pgCounter++;
        }
        int avarageProjectGrades = pgSum / pgCounter;


        int totalPointCounter = ((avarageProjectGrades * 25) / 100) + ((avarageHomeWorkGrades * 25) / 100) + (FinalGrade * 40) / 100 + (countTrue * 10) / 100;

        if(totalPointCounter > GradePointForHighHonour)
        {
            Console.WriteLine("HighHonour");

        }
        else if(totalPointCounter >= GradePointForHonour && GradePointForHighHonour > totalPointCounter)
        {
            Console.WriteLine("Honour");
        }
        else
        {
            Console.WriteLine("Normal");
        }

    }

}