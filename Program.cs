using System;

namespace Lista{
    class Program {
        static void Main(string[] args) {
            ListMine lista = new ListMine();
            // lista.insertStart(1);
            lista.insertSort(-2);
            lista.insertSort(11);
            lista.insertEnd(-12);
            lista.Search(6);
            lista.remove(-2);
            lista.remove(-12);
            // lista.insertEnd(2);
            lista.showList();

        }
    }
}