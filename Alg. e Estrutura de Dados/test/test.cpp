#include <iostream>

using namespace std;

int main(){
    int v;
    float result, n1, n2;

    cout  << "Digite dois numeros: " << endl;
    cin >> n1;
    cin >> n2;
    cout << "Digite um numero, para multiplicação 1, subtração 2, soma 3: " << endl;
    cin >> v;

    if (v == 1)
        result = n1 * n2;
    else if (v == 2)
        result = n1 - n2;
    else if (v == 3)
        result = n1 + n2;
    
    cout << "O resultado é: " << result << endl;
    return 0;
}