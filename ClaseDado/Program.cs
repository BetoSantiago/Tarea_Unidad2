using System;

namespace ClaseDado
{
    class Dado
    {
        private string color;
        private string tamaño;
        private int valor;
        public static Random random = new Random();
        public Dado(string color,string tamaño)
        {
            this.color = color;
            this.tamaño = tamaño;
        }
        public void Tirar()
        {           
            valor = random.Next(1, 6);
        }
        public void Imprimir()
        {
            Console.WriteLine("\n El Valor Del Dado {0} {1} Es: {2}",color,tamaño,valor);
        }
        public int RetornarValor()
        {
            return valor;
        }
        public void Imprimir(string n)
        {
            Console.WriteLine("\n EL Dado {0} {1} Es El Mayor Con : {2}",color,tamaño,valor);
        }
    }
    class Lanzamiento
    {
       Dado dado1,dado2, dado3;
        //public List<Dado> dados;
        public Lanzamiento()
        {
            dado1 = new Dado("Blanco", "Grande");                    
            dado2 = new Dado("Negro", "Mediano");
            dado3 = new Dado("Rojo", "Chico");
        }
        public void Tiro()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.RetornarValor() > dado2.RetornarValor() && dado1.RetornarValor() > dado3.RetornarValor())
            {
                dado1.Imprimir("dado1");
            }
            else if (dado2.RetornarValor() > dado1.RetornarValor() && dado2.RetornarValor() > dado3.RetornarValor())
            {
                dado2.Imprimir("dado2");
            }
            else if (dado3.RetornarValor() > dado1.RetornarValor() && dado3.RetornarValor() > dado2.RetornarValor())
            {
                dado3.Imprimir("dado3");
            }
            else if (dado1.RetornarValor() == dado2.RetornarValor() && dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("\n Todos Los Dados Valen Lo Mismo");
            }
            else
            {
                Console.WriteLine("\n Hay Mas De Dos Dados Mayores");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Lanzamiento L = new Lanzamiento();
            L.Tiro();
        }
    }
}
