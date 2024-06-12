namespace ConsoleApp1;

using System;

public class Car
{
    public string Color { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }

    public Car(string color, string model)
    {
        Color = color;
        Model = model;
        Speed = 0;
    }

    public void Start()
    {
        Speed = 10;
        Console.WriteLine("자동차가 출발했습니다. 현재 속도: " + Speed + "km/h");
    }

    public void Stop()
    {
        Speed = 0;
        Console.WriteLine("자동차가 멈췄습니다. 현재 속도: " + Speed + "km/h");
    }

    public void Accelerate(int increase)
    {
        Speed += increase;
        Console.WriteLine("가속 중... 현재 속도: " + Speed + "km/h");
    }
}

public class Program
{
    public static void Main()
    {
        Car myCar = new Car("빨강", "스포츠카");

        Console.WriteLine("자동차 정보:");
        Console.WriteLine("색상: " + myCar.Color);
        Console.WriteLine("모델: " + myCar.Model);

        myCar.Start();
        myCar.Accelerate(20); // 속도 증가
        myCar.Stop();
    }
}
