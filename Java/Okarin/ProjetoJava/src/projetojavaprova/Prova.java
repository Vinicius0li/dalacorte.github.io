/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projetojavaprova;

import java.util.ArrayList;
import javax.swing.*;
import javax.swing.JFrame;
import javax.swing.JTextArea;

/**
 *
 * @author Okarin
 */
public class Prova extends Extends implements Implements {

    public Prova(boolean p) {
        p = true;
    }

    public String toString(boolean p) {
        return "Prova{" + '}';
    }

    public class Frame extends JFrame {
        
        private JTextArea texto = new JTextArea();

        public Frame() {
            super("Meu Notepad");
            this.montaJanela();
        }

        private void montaJanela() {
            this.getContentPane().add(texto);
        }
    }

    public static void main(String[] args) {

        Extends e = new Instancia();
        e.sOut();

        ArrayList<String> bandas = new ArrayList<String>();
        int vetor[] = new int[10];
        int matriz[][] = new int[10][10];
        int matrizT[][][] = new int[10][10][10];

        JOptionPane.showInputDialog(null, "");
        JOptionPane.showMessageDialog(null, "");

    }

    @Override
    public void override() {
        System.out.println("sout");
    }

}
