using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true;  //true or false

			//bool _test = 5>10;

			int[] _i = new int[] { 4,3,2};
			Console.WriteLine ("Въведете номер елемент от масива:");
			int _ui = 0;   //Convert.ToInt32 ( Console.ReadLine());
			string _input="0";

			_input = Console.ReadLine ();

			bool ch1 = int.TryParse (_input, out _ui);
			bool ch2 = _ui <= _i.Length;
			bool ch3 = _ui > 0;

			if (ch1 && ch2 && ch3) {
				Console.WriteLine (_i[_ui-1]);
			}
			if (!ch1) {
				Console.WriteLine ("\nНевалидни данни - не е цяло число\n");
			}
			if (!ch2) {
				Console.WriteLine ("\nПо-голем индекс\n");
			}
			if (!ch3 && ch1) {
				Console.WriteLine ("\nПо-малък индекс\n");
			}






//			bool _check01 = _ui <= _i.Length;
//			bool _check02 = _ui > 0;
//
//			bool ex1 = _check01 && _check02;   //логическо И
//			bool ex2 = _check01 || _check02;   //логически ИЛИ
//			bool ex3 = !_check01;              //отрицание 
//
//			Console.WriteLine ("Логическо И: " + ex1.ToString());
//			Console.WriteLine ("Логическо ИЛИ: " + ex2.ToString());
//			Console.WriteLine ("Отрицание на " + _check01.ToString() + ": " + ex3.ToString());

//			if (_ui > 0 && _ui < _i.Length) {
//				Console.WriteLine (_i[_ui-1]);
//											}
//			else 
//				{
//				if (_ui>_i.Length ){
//					Console.WriteLine ("По-голям индекс");
//			         }
//				if (_ui<=0){
//					Console.WriteLine ("По-малък индекс");
//				     }
//			     }
//
//			var I = new Random();
//			int[] l = new int[4] {I.Next(0,3), I.Next(0,3), I.Next(0,3),0};
//			if ( (l[0] == l[1]) && (l[0] == l[2]) ) l[3] = 10;
//			else if ( (l[0] == l[1]) || (l[0] == l[2]) || (l[1] == l[2]) ) l[3] = 5;
//			string[] row = {"портокали","банани","лимони"};
//			Console.WriteLine(row[l[0]]+" "+row[l[1]]+" "+row[l[2]]+"\nПечелите "+l[3]+" точки");
		}
	}
}
