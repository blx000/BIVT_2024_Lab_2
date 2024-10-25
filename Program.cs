using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        double r = 2;

        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 1 / (1000)){
            answer = true;
        } else {
            answer = false;
        }
        // end
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x)) <= 1) {
            answer = true;
        } else {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) {
            if (a > b)
                answer = a;
            else
                answer = b;
        } else {
            if (a > b)
                answer = b;
            if (a < b)
                answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        // code here
        if (a > b) {
            if (b > c)
                answer = b;
            else
                answer = c;
        } else {
            if (a > c)
                answer = a;
            else
                answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s) * Math.Sqrt(2);
        if (d >= a)
        {
            answer = true;
        } else {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        if (a >= d)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end  

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = (x * x - 1);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
            answer = 1;
        else if (x <= 0 && x > (-1))
            answer = 1 + x;
        else
            answer = 0;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x > 1)
            answer = -1;
        else if (x <= (-1))
            answer = 1;
        else
            answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
            answer += double.Parse(Console.ReadLine());
        answer /= n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for (int i = 0; i < n; i++)
        {
            
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            if (Math.Sqrt(((x - a) * (x - a)) + ((y - b) * (y - b))) < r)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out weight);
            weight = double.Parse(input, new CultureInfo("en-US"));
            weight = Convert.ToDouble(input, new CultureInfo("en-US"));
            if (weight < 30)
                answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x;
        double y;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            if (Math.Sqrt(x * x + y * y) > r1 && Math.Sqrt(x * x + y * y) < r2)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double x;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            if (x <= norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            if (x >= 0 && x <= Math.PI && y <= Math.Sin(x))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            if (x >= 0 && y >= 0)
            {
                answer1++;
            } else if (x <= 0 && y <= 0) {
                answer3++;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answerLength = l;
                answer = i + 1;
                answerLength = Math.Round(answerLength, 2);
                Console.WriteLine(answer);
                Console.WriteLine(answerLength);
            }
        }

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double x;
        // code here
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            if (x < answer)
            {
                answer = x;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double x, y, z, k;
        // code here;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            string input3 = Console.ReadLine();
            double.TryParse(input3, new CultureInfo("en-US"), out z);
            z = double.Parse(input3, new CultureInfo("en-US"));
            z = Convert.ToDouble(input3, new CultureInfo("en-US"));
            string input4 = Console.ReadLine();
            double.TryParse(input4, new CultureInfo("en-US"), out k);
            k = double.Parse(input4, new CultureInfo("en-US"));
            k = Convert.ToDouble(input4, new CultureInfo("en-US"));
            if (x != 2 && z != 2 && y != 2 && k != 2 && x != 3 && z != 3 && y != 3 && k != 3)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double x, y, z, k;
        // code here;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double.TryParse(input, new CultureInfo("en-US"), out x);
            x = double.Parse(input, new CultureInfo("en-US"));
            x = Convert.ToDouble(input, new CultureInfo("en-US"));
            string input2 = Console.ReadLine();
            double.TryParse(input2, new CultureInfo("en-US"), out y);
            y = double.Parse(input2, new CultureInfo("en-US"));
            y = Convert.ToDouble(input2, new CultureInfo("en-US"));
            string input3 = Console.ReadLine();
            double.TryParse(input3, new CultureInfo("en-US"), out z);
            z = double.Parse(input3, new CultureInfo("en-US"));
            z = Convert.ToDouble(input3, new CultureInfo("en-US"));
            string input4 = Console.ReadLine();
            double.TryParse(input4, new CultureInfo("en-US"), out k);
            k = double.Parse(input4, new CultureInfo("en-US"));
            k = Convert.ToDouble(input4, new CultureInfo("en-US"));
            if (x == 2 || z == 2 || y == 2 || k == 2)
                answer++;
            avg += x + y + z + k;
        }
        avg /= 4 * n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4.0;
                break;
            default:
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;
        if (type < 0 || type > 2)
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(B * B - A * A) * Math.PI;
                break;
            case 2:
                if (A >= 2 * B)
                {
                    answer = 0;
                    break;
                }
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4.0;
                break;
            default:
                break;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;
        double weight;
        // code here
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out weight)) { 
            if (weight < 30) {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        double x, y;
        // code here
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x) && double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
        {
            if (x >= 0 && x <= Math.PI && y <= Math.Sin(x))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;
        double x;
        // code here
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
        {
            if (x < answer)
            {
                answer = x;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
