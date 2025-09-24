using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class Programa : Form
{
    private object textBox1;

    private void Mostrar(int[] arreglo)
    {
        textBox1.Clear();
        for (int índice = 0; índice < arreglo.Length; índice++)
        {
            textBox1.AppendText(Convert.ToString(arreglo[índice])
            + "\r\n");
        }
    }
}

