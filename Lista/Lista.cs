public class Lista{

    //Atributos
    public No inicio; //cabeça
    public No fim; //cauda

    //Construtor
    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    //Métodos
    public Boolean estaVazia(){
        if(inicio == null && fim == null){
            return(true);
        }
        return(false);
    }

    public void inserirInicio(int valor){

        //CRIAR NOVO NO
        No novoNo = new(valor);

        if(this.estaVazia()){ //LISTA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{ 
            novoNo.prox = this.inicio; //Novo no aponta para o inicio da lista
            this.inicio = novoNo; //O inicio da lista passa a ser o novo no
        }
    }

    public void inserirFinal(int valor){
        //IMPLEMENTAR A INSERÇÃO DE UM ELEMENTO NO INICIO
    }

    public Boolean remover(int valor){
        //IMPLEMENTAR A REMOÇÃO DE UM VALOR INDICADO PELO USUÁRIO

        No noAnterior, noAtual;
        noAnterior = noAtual = null;
        Boolean verif = this.consulta(valor, ref noAnterior, ref noAtual);
        if(verif == true){
            noAtual = this.inicio;
            noAnterior = null;
            if(noAtual.valor == valor){//remover inicio
                
            }
            else if(){//remover fim

            }
            else{//remover meio

            }
            return(true);
        }
        return(false);
    }

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior){ 
        noAtual = this.inicio;
        noAnterior = null;
        while(noAtual != null){ // percorrer lista
        if(noAtual.valor == valor){
            return true;
        }
            noAnterior = noAtual; //Copia atual
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public void imprimir(){

        No noAux = this.inicio;
        
        Console.WriteLine("Elementos: ");
        
        while(noAux != null){
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
    }
}