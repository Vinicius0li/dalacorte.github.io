#include <stdio.h>
#include <locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	char numero[20];
	int i;
	
	printf("Informe um n�mero: ");
	gets(numero);
	
	printf("\nN�meros pares inclusos no n�mero %s:\n",numero);
	for(i = 0; i < numero[i]; i++){
		if (numero[i]%2 == 0){
			printf("\n%c",numero[i]);
		}
	}
	
}
