package l07e01;
import java.util.Scanner;
public class L07E01 {

    public static void main(String[] args) {
         Scanner entrada = new Scanner (System.in);
            
            int notas[] = new int [4];
            int nota = 0;
            int media = 0;
            int i = 0;
            
            for(int n = 0; n<4;n++)
            {
                nota = entrada.nextInt();
                notas[n]=nota;
                media=media+notas[n];
                System.out.println("Nota "+n+"="+notas[n]);
            }
            media=media/4;
            System.out.println("Média = "+media);
            
     }         
 
}
