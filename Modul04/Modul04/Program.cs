using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{"Иван",	 "Георгиев",	 "25" },
				{"Цветан",   "Цветанов",     "45" },
				{"Бойко",	 "Борисов", 	 "57" },
				{"Ивана",	 "Тръмп",	     "40" },
				{"Анджелина", "Джоли", 	     "45" },
				{"Брад", 	 "Пит",	         "46" }
			};
			//Антетка на таблицата
			Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight(12) + "Години".PadRight(12));
			Console.WriteLine ("====================================");

			//Цикъл с while
//			int i=0;
//			while (i<_table.Length/3){
//				Console.WriteLine (
//					_table[i,0].PadRight (12) +
//					_table[i,1].PadRight (12) +
//					_table[i,2].PadRight (12) 
//				);
//				i++;
//			}

			//Цикъл do...while
			int i=0;
			do
			{
				Console.WriteLine (
					_table[i,0].PadRight (12) +
					_table[i,1].PadRight (12) +
					_table[i,2].PadRight (12) 
									);
				i++;
			}
			while (i < _table.Length/3 );



//			//Тяло на таблицата
//			//Цикъл for
//			for (int ii = 0; ii < _table.Length/3; ii++) {
//				for (int jj=0; jj<3; jj++){
//					Console.Write (_table[ii,jj].PadRight(12));
//					
//				}
//
//				Console.WriteLine ( );
//			}



//			//Задачата
//
//			int[] a = {1,2,3};
//			int i=0, j=0;
//			int r_op=0; // Тук записваме произволната команда
//			int r_num1=0; // Номер на първо произволно число от масива
//			int r_num2=0; // Номер на второ произволно число от масива
//			var r = new Random();
//
//			string rs = ""; // Тук ще пазим текстовата формула до момента
//			int res = 0; // Тук ще смятаме произволно
//			int found = 0; // Тук пазим колко формули сме намерили до момента
//
//			for(i=0; i<100;i++) {
//				rs = ""; // Всяка нова итерация ще изтриваме rs и res 
//				res = 0; 
//				for(j=0; j<20; j++) {
//					r_op = r.Next(0,3); // Тук се решава дали ще събираме, изваждаме или делим
//					r_num1 = r.Next(0,3);
//					r_num2 = r.Next(0,3);
//
//					switch(r_op) {
//					case 0: 
//						{
//							res += a[r_num1] + a[r_num2];
//							rs += a[r_num1]+" + "+a[r_num2]+ " + ";
//							break;      
//						}
//					case 1: 
//						{
//							res += a[r_num1] * a[r_num2];
//							rs += a[r_num1]+" * "+a[r_num2]+ " + ";
//							break;      
//						}
//					case 2: 
//						{
//							res += a[r_num1] - a[r_num2];
//							rs += a[r_num1]+" - "+a[r_num2]+ " + ";
//							break;      
//						}
//					}
//
//					if (res == 15) { // Воала. Намерихме правилна формула
//						Console.WriteLine(rs+ " 0 = 15\n");
//						found++;
//						break;
//					}
//
//				}
//				if (found > 5) break; // Не искаме повече от 5 формули
//
//			}
		}
	}
}
