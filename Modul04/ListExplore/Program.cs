using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput = "";
			//List
			List<int> _list = new List<int>();
			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//Потребителски код
			do {
				Console.WriteLine("? ");
				_userinput = Console.ReadLine();

					//Добавяне на стойности
				if ( _userinput.ToLower().Contains("add") )
				{
					try{
					int _add = 0;
						if ( int.TryParse  (_userinput.Split(' ')[1] , out _add))
						{
							_list.Add (_add);
						}
					}catch{}
					Console.WriteLine();
				}


					//Преглед на List
				if (_userinput.ToLower().Contains ("show"))
				{
					Console.Write ("Списък: ");
					foreach(int value in _list)
					{
						Console.Write(value.ToString() + ", ");
					}


//					Console.Write ("_list: ");
//					for (int i=0; i<_list.Count; i++)
//					{
//						Console.Write( _list[i] );
//						if ( i!=_list.Count-1 ) Console.Write(", ");
//					}
					Console.WriteLine("\n");
				}


					//Размер на List
				if (_userinput.ToLower().Contains ("size"))
				{
					Console.WriteLine("Размер на списъка: " + _list.Count.ToString() + "\n");
				}



			}
			while(_userinput != "exit" );


			//Задача
//			List<string> z = new List<string> ();
//			z.Add("Иван");
//			z.Add("Драган");
//			Console.WriteLine( z.Count );
//			if (z.Contains("Драган")) Console.WriteLine("Драган е тук");

//			2
//			Action<string> cw = Console.WriteLine;
//			List<string> z = new List<string> ();
//
//			z.Add("ябълка");
//			z.Add("круша");
//			z.Add("мармалад");
//			z.Add("грозде");
//
//			int i = z.IndexOf("мармалад");
//			z.RemoveAt(i);
//			foreach(string x in z) {
//				cw(x);
//			}


			//задача
//			Action<string> cw = Console.WriteLine;
//			List<string> z = new List<string> ();
//
//			z.Add("ементал");
//			z.Add("дръжка");
//			z.Add("вафла");
//			z.Add("грозде");
//			z.Add("боркан");
//			z.Add("амфибия");
//
//			z.Sort();
//			cw( string.Join(", ",z) );
//			z.Reverse();
//			cw( string.Join(", ",z) );


			//Задача 09



			List<string> brands = new List<string> () { //Това е краткия начин по който да дефинираме и запълним лист
				"sony","cocacola","pepsi","ibm","mentos","panasonic","fanta",
				"sprite","apple","microsoft","google","mcdonalds","samsung",
				"facebook","disney","pixar","amazon"}; //Лист с популярни брандове

			List<string> srichki = new List<string> (); // Ще извадим срички от брандовете и ще ги сложим тук
			int i =0;

			List<string> glasni = new List<string>() {"a","e","i","o","u","y"}; // Тук ще държим гласните

			foreach(string brand in brands) {

				for(i=0; i<brand.Length-1; i++) {
					if (glasni.Contains(brand[i].ToString()) ||    // Ако сричката няма гласна, то ще я отхвърлим
						glasni.Contains(brand[i+1].ToString() ))
						srichki.Add( ""+ brand[i]+brand[i+1] );      // Всички останали срички ги запомняме
				}

			}

			Console.WriteLine("Открити срички: "+string.Join(" ",srichki)+"\n");   // Ще покажем сричките на екрана

			var r = new Random();

			string my_brand = "";   // Тук ще пишем произволни срички
			Console.WriteLine("Нови брандове:");
			for(int k=0; k<20; k++) { // Искаме да създадем 20 нови бранда
				my_brand= ""; // Всеки път трябва да започваме от нищо
				for(int j=0; j<r.Next(2,10); j++) { // Искаме новия бранд да е с от 2 до 10 срички

					my_brand += srichki[ r.Next(0,srichki.Count-1) ]; // Добравяме произволна сричка към новия бранд
				}
				Console.WriteLine(my_brand); // Показваме новия бранд на екрана
			}



		}
	}
}
