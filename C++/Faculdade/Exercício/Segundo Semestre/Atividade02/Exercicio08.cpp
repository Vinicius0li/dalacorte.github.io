#include <stdio.h>
#include <locale.h>

main(){
	setlocale(LC_ALL, "Portuguese");
	char nome1[30], nome2[30];
	int i, tamanho = 0;
	
	printf("Digite o 1� nome: ");
	gets(nome1);
	
	printf("Digite o 2� nome: ", i+1);
	gets(nome2);
	
	for (i = 0; i < nome1[i]; i++)
		tamanho+=1;
		printf("\n1� Nome: %s - %d letras.", nome1,tamanho);	
	
	tamanho = 0;
	
	for (i = 0; i < nome2[i]; i++)
		tamanho+=1;
		printf("\n2� Nome: %s - %d letras.", nome2,tamanho);	
		
	
}
