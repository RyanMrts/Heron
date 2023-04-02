double lado1, lado2, lado3; double s; double area;
// s = semiperimetro.
    Console.Write("Digite o lado 1 do triângulo: ");
    lado1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o lado 2 do triângulo: ");
    lado2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o lado 3 do triângulo: ");
    lado3 = Convert.ToDouble(Console.ReadLine());

s = (lado1 + lado2 + lado3) / 2;  
area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

    Console.WriteLine($"Semiperimetro: {s}"); 
    Console.WriteLine($"Area: {area}");

