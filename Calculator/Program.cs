namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo a Calculadora");
            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Digite uma opção: ");
            short res = short.Parse(Console.ReadLine());
        }

        public static void Adicao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da adição é: {num1 + num2}");
        }

        public static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
        }

        public static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
        }

        public static void Divisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
        }


    }
}