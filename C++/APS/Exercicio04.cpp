#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int quantidade, *numeros, pares = 0, impares = 0;
	
	printf("Informe a quantidade de n�meros positivos que deseja inserir: ");
	scanf("%d",&quantidade);
	numeros = (int *)malloc(quantidade * sizeof(int));
	
	for(int i = 0; i < quantidade; i++){
		printf("\nInforme o %d� n�mero: ",(i+1));
		scanf("%d",&numeros[i]);
		
		
		if ((i+1)%2 == 0){
			pares += numeros[i];
		} else {
			impares += numeros[i];		
		}
	}
	printf("\nA soma dos n�meros pares �: %d", pares);
	printf("\nA soma dos n�meros �mpares �: %d", impares);
		
}
