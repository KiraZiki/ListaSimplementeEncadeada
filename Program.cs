Lista lista = new();

lista.inserirInicio(10);
lista.inserirInicio(7);
lista.inserirInicio(12);
lista.inserirInicio(-5);

int valor = -7;
No noAnterior, noAtual;
noAnterior = null;
noAtual = null;

Boolean verif = lista.consulta(valor, ref noAtual, ref noAnterior);
if(verif == true) Console.WriteLine("Número encontrado!");
else Console.WriteLine("Número não encontrado!");

lista.imprimir();