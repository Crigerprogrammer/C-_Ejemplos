using System;

class Tienda{
	static void Main(string[] args){
		string cliente;
		int montoCliente;
		int contCli = 0;
		int montoTotal = 0;
		string opc;

		Console.WriteLine("REGISTRO DE VENTAS");
		Console.WriteLine("==================");
		Console.WriteLine();
		Console.Write("Registrar venta(S/N)?: ");
		opc = Console.ReadLine();
		Console.WriteLine();

		while(opc == "S" || opc == "s")
		{
			Console.Write("Nombre del cliente: ");
			cliente = Console.ReadLine();
			contCli += 1;
			Console.Write("Monto: ");
			montoCliente = int.Parse(Console.ReadLine());
			montoTotal += montoCliente;
			Console.WriteLine();
			Console.Write("Registrar Venta (S/N)?: ");
			opc = Console.ReadLine();
			Console.WriteLine();
		}
		Console.WriteLine();
		Console.Write("Cantidad total de las ventas: " + montoTotal);
		Console.WriteLine();
		Console.Write("Cantidad de Clientes atendidos: "+ contCli);
		Console.ReadLine();
	}
}