using System;

namespace Exercise_1;
class Program
{
    //dimana 48 merupakan hasil dari 28+10+20+20-2x15
    private int[] dina = new int[48];
    int n;
    private readonly object arr;
    private int i;

    //Fungsi/Method untuk menerima masukan
    public void read()
    {
        //menerima angka untuk menentukan banyak data yang disimpan dalam array
        while (true)
        {
            Console.Write("Masukkan banyaknya elemen pada array : ");
            //string s untuk terbaca
            string s = Console.ReadLine();
            //Parse untuk mengubah dalam bentuk desimal
            n = Int32.Parse(s);
            //pengambil keputusan
            //jika kurang dari 28 maka akan dilanjutkan
            if (n <= 48)
                break;
            //jika lebih dari 28 maka akan muncul pernyataan maksimum elemen 
            else
                Console.WriteLine("\nArray maksimum elemen 28.\n");
        }
        Console.WriteLine("");
        Console.WriteLine("-----------------");
        Console.WriteLine("Maukkan elemen Array");
        Console.WriteLine("");
        //code memasukkan elemen array
        for (int i = 0; i < n; i++)
        {
            Console.Write("<" + (i + 1) + "<");
            string s1 = Console.ReadLine();
            dina[i] = Int32.Parse(s1);
        }
    }
    public void display()
    {
        //menampilkan array yang tersusun
        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Elemen array yang telah tersusun");
        Console.WriteLine("--------------------------------");

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(dina[j]);
        }
        Console.WriteLine("");
    }
    public void Exercise_1Array()
    {
        //for n-1 passes
        for (int j = 1; j < n; j++) 
        {
            if (dina[j] > dina[j + 1])
            {
                int temp;
                temp = dina[j];
                dina[j] = dina[j + 1];
                dina[j + 1] = temp;
            {
                    Console.Write("Masukkan banyaknya elemen pada array : ");
                    string s1 = Console.ReadLine();
                    n = Int32.Parse(s1);
                }
            }
        }
    }
    static void main(string[] args)
    {
        Program myList = new Program();
        myList.read();
        myList.display();
        myList.Exercise_1Array();
        myList = new Program();
    }
}