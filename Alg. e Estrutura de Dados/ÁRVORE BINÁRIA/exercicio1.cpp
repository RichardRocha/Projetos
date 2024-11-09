#include <iostream>

using namespace std;

//representar nossa estrutura base da arvore

struct No {
    int valor;
    No* esq;
    No* dir;
};

//a raiz sera global e vale NULL
No* raiz = NULL; //NULL pq nao tem arvore ainda

//funcao para inserir um valor na estrutura da arvore 
void inserir(int valor) {

    //Criando o elemento com o valor a ser inserido!
    No* el = (No*)malloc(sizeof(No));
    el->valor = valor;
    el->dir = NULL;
    el->esq = NULL;

    //Caso não exista arvore, a raiz passa a ser o proprio el
    if (raiz == NULL)
        raiz = el;
    else {
        No* aux = raiz; //Precisamos de um nó auxiliar para percorrer a estrutura
    

    while (true){
        //AVALIANDO O LADO ESQUERDO! aux = "raiz"
        if (valor < aux->valor){
            if (aux->esq == NULL) {
                aux->esq = el;
                return;      
            }
            aux = aux->esq; //Caso não achemos uma posição valida, continuamos a navegar para esquerda
        }
        //AVALIANDO O LADO DIREITO!
        else if (valor > aux->valor){
            if (aux->dir == NULL){
                aux->dir = el;
                return;
            }
            aux = aux->dir;  
        }
    }
    
    }
}

No* buscarElemento(int valor) //Para retornar o conteudo, colocar no lugar de No* int
{
    No* aux = raiz;

    //Verificar se existe arvore para buscar valor
    if (aux == NULL)
        return NULL;
    
    while (true) {
        if (valor == aux->valor)
            return aux;
        else if (valor < aux->valor) 
        {
            if (aux->esq == NULL)
                return NULL;
            aux = aux->esq;
        }
        else if (valor > aux->valor) {
            if (aux->dir == NULL)
                return NULL;
            aux = aux->dir;

        }   
    }  
}

//REALIZANDO UM PERCURSO IN-ORDEM NA ARVORE
void inOrdem (No* raiz) {
    if (raiz != NULL) {
        inOrdem (raiz->esq);
        cout << raiz->valor << "\t";
        inOrdem (raiz->dir);
    }

}

//REALIZANDO UM PERCURSO PRE-ORDEM NA ARVORE
void preOrdem (No* raiz) {
    if (raiz != NULL) {
        cout << raiz->valor << "\t";
        preOrdem (raiz->esq);
        preOrdem (raiz->dir);
    }
}

//REALIZANDO UM PERCURSO POS-ORDEM NA ARVORE
void posOrdem (No* raiz) {
    if (raiz != NULL) {
        posOrdem (raiz->esq);
        posOrdem (raiz->dir);
        cout << raiz->valor << "\t";
    }
}

int main()
{
    //Utilizando o método de inserir
    inserir(15);
    inserir(7);
    inserir(21);
    inserir(13);
    inserir(11);
    inserir(5);
    
    No* retorno = buscarElemento(21);

    if (retorno != NULL)
        cout << "Valor encontrado: " << retorno->valor;
    else 
        cout << "Valor não existe" << endl;

    cout << "Valor exibidos no percurso IN-ORDEM" << endl;
    inOrdem(raiz);

    cout << "Valor exibidos no percurso PRE-ORDEM" << endl;
    preOrdem(raiz);

    cout << "Valor exibidos no percurso POS-ORDEM" << endl;
    posOrdem(raiz);

    return 0;
}