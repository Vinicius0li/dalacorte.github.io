#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int numeros[5], i = 0, j = 0;
	
	for(i = 0; i < 5; i++){
		printf("Informe o %d� valor: ",(i+1));
		scanf("%d",&numeros[i]);
	}
	
	printf("\nN�meros na ordem digitada: \n");
	for(i = 0; i < 5; i++){
		printf("\n%d",numeros[i]);
	}
	
	printf("\n\nN�meros em ordem crescente: \n");
	for (j = 0; j < 4; j++){
		for (i = 0; i < 4; i++){
  			if (numeros[i] > numeros[i+1]){
     			int temp = numeros[i];
     			numeros[i] = numeros[i+1];
     			numeros[i+1] = temp;
  			}
		}
	}
	for(int i = 0; i < 5; i++){
		printf("\n%d",numeros[i]);
	}
	
	printf("\n\nN�meros em ordem decrescente: \n");
	for (j = 4; j > 0; j--){
		for (i = 4; i > 0; i--){
  			if (numeros[i] > numeros[i-1]){
     			int temp = numeros[i];
     			numeros[i] = numeros[i-1];
     			numeros[i-1] = temp;
  			}
		}
	}
	for(int i = 0; i < 5; i++){
		printf("\n%d",numeros[i]);
	}
	
}
