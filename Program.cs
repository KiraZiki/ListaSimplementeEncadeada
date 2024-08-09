using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            // lista.insertStart(1);
            lista.insertSort(-2);
            lista.insertSort(11);
            lista.insertEnd(-12);
            Boolean Search = List.Search(int value, ref Node current, ref  Node before);
            if(Search == true) Console.WriteLine("A busca encontrou!");
            else Console.WriteLine("A busca não encontrou!");
            lista.Search(6);
            lista.remove(-2);
            lista.remove(-12);
            lista.showList();

            //Ex 3
            lista.insertSort("Matemática," + " Diurno," + " " + 3 + "Horas," + "Professor Bruno");
            lista.insertSort("História," + " Matutino," + " " + 2 + "Horas," + "Professor Bernado");
            lista.Search("Matemática");
            lista.remove("História");
            lista.showList();

        }
    }
}