using System;

class Matriz5{
	private int[,] mat;

	public void Cargar(){
		Console.Write("Cuantas filas tiene la matriz: ");
		string linea;
		linea = Console.ReadLine();
		int filas = int.Parse(linea);
		Console.Write("Cuantas columnas tiene la matriz: ");
		linea = Console.ReadLine();
		int columnas = int.Parse(linea);
		mat = new int [filas, columnas];
		for(int f = 0; f < mat.GetLength(0); f++){
			for(int c = 0; c < mat.GetLength(1); c++){
				Console.Write("Ingrese componente: ");
				linea = Console.ReadLine();
				mat[f,c] = int.Parse(linea);
			}
		}
	}

	public void Imprimir(){
 		for(int f = 0; f < mat.GetLength(0); f++)
            {
                for(int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f,c]+" ");
                }
                Console.WriteLine();
      	    }
	}

	public void ImprimirUltimaFila() 
        {
    	    Console.WriteLine("Ultima fila");
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                 Console.Write(mat[mat.GetLength(0)-1,c]+" ");
            }
        }

    static void Main(string[] args)
        {
            Matriz5 ma = new Matriz5();
            ma.Cargar();
            ma.Imprimir();
            ma.ImprimirUltimaFila();
            Console.ReadKey();
        }
}