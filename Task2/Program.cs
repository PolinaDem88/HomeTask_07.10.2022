/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

void GetDistanceBetweenTwoPoint(int firstx, int firsty, int firstz,  int secondx, int secondy, int secondz)
{

    double result = 0;
    double tempx = Math.Pow(secondx - firstx, 2);
    double tempy = Math.Pow(secondy-firsty, 2);
    double tempz = Math.Pow(secondz-firstz, 2);
    
    result = Math.Sqrt(tempx + tempy + tempz);
    
    Console.WriteLine($"Расстояние между точками равно {result}");
}
GetDistanceBetweenTwoPoint(7,-5,0,1,-1,9); 