using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime=0, familia, godini};


		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2,3];

			//Въвеждане на първи ред
			table[0, (int) ti.ime]="Мартин";  table[0, (int) ti.familia]="Мартинов"; table[0, (int) ti.godini]="25 г.";
			//Въвеждане на втори ред
			table[1, (int) ti.ime]="Мартинчо";table[1, (int) ti.familia]="Мартинов"; table[1, (int) ti.godini]="30 г.";

			//Печат
			Console.Write("Кой ред искате да видите?");
			int i = Convert.ToInt32 (Console.ReadLine()) - 1;
//			Console.WriteLine (i);
			Console.WriteLine (
				(table[i, (int) ti.ime])[0] + ". " + 
				 table[i, (int) ti.familia] + ", " + 
				 table[i, (int) ti.godini]
							);
			    


//			//Деклариране на масив с тип данни string
//			string[] row = new string[3];
//			row[0]="Ред 1";
//			row[1]="Ред 2";
//			row[2]="Ред 3";

//
//			Console.WriteLine ("Масив  row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");
//
//			//Декларация на масив и инициализация чрез разделяне на стринг
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Броят на елементите от масива\n" + "1,2,3,4,5,6,7,8,9\nе: " + parse.Length);
//
//			//Представяне на масив в стринг
//			string list1 = string.Join (";", parse);
//			Console.WriteLine("Новият стринг е\n" + list1+ "\n\n");
//
//			//Задача 1
//			int[] masiv = new int[20];
//			string s;
//
//			for (int i = 0; i < 20; i++) {
//				masiv [i] = i * 5;
//				if (i < 19)
//					s = ";";
//				else
//					s = "\n";
//				Console.Write (masiv [i] + s);
//											}
//
//			//Задача 2
//			Console.WriteLine("\n\nВъведете данни за първи масив, разделени със , :\n");
//			string[] in1 = Console.ReadLine().Split (',');
//			Console.WriteLine ("Въведете данни за втори масив, разделени със , :\n");
//			string[] in2 = Console.ReadLine().Split (',');
//			int ii=0;
//			if (in1.Length != in2.Length) ii=1;
//			if (ii==0){
//				for (int j=0; j<in1.Length;j++){
//					if (in1[j]!=in2[j]) ii=1;
//												}
//					
//					}
//			if (ii==0)
//				Console.WriteLine ("Масивите са еднакви.\n");
//			else
//				Console.WriteLine ("Масивите  не са еднакви.\n\n");
//
//
//			//Задача 3
//			Console.WriteLine("\n\nВъведете данни за трети масив, разделени със , :\n");
//			string[] in3 = Console.ReadLine().Split (',');
//			int jj = in3.Length;
//			ii = 0;
//				for (int n=0;n<jj/2;n++){
//				if (in3[n]!=in3[jj-n-1]) ii=1;
//										}
//					if (ii==0)
//					Console.WriteLine ("Масивът е симетричен.\n");
//					else
//					Console.WriteLine ("Масивът не е симетричен.\n\n");
//
//
//			//Задача 4
//			Console.WriteLine("\n\nВъведете данни за четвърти масив, разделени със , :\n");
//			string[] in4 = Console.ReadLine().Split (',');
//			int jm = in4.Length;
//
//			for (int m=jm-1;m>=0;m--){
//				if (m != 0)
//					s = ";";
//				else
//					s = "\n";
//				Console.Write (in4 [m] + s);
//			}
//
//			//Ротативка
//			string[] raw = {"портокали","банани","круши"};
//			var r=new Random();
//			int a1=r.Next(0,3);
//			int a2=r.Next(0,3);
//			int a3=r.Next(0,3);
//			Console.WriteLine(raw[a1]+" "+raw[a2]+" "+raw[a3]);
//						

		}
	}
}
