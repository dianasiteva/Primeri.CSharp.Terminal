using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4,3,2};
			Console.WriteLine ("Въведете номер елемент от масива:");
			int _ui = 0;  
			string _input="0";

			_input = Console.ReadLine ();

			bool ch1 = int.TryParse (_input, out _ui);

			switch (_ui) {
			case 1:
				Console.Write ("1ви елемент е : ");
				Console.WriteLine (_i [_ui - 1]);
				break;
			case 2:
				Console.Write ("2ри елемент е : ");
				Console.WriteLine (_i [_ui - 1]);
				break;
			case 3:
				Console.Write ("3ти елемент е : ");
				Console.WriteLine (_i [_ui - 1]);
				break;
			default:
				Console.Write ("Грешка!");
				break;
			}

//			_ui = (_ui <= _i.Length) ? _ui : 3;
//			_ui = (_ui > 0) ? _ui : 1;
//
//			if (ch1) {
//				Console.WriteLine (_i[_ui-1]);
//			}
//
//
//			//задача
//			int a=5, b=10, c=3;
//			int x = 0;
//			x = (a > b) ? a : b;
//			x += (b > c) ? 1 : -1;
//			x += (a < c) ? 3 : -2;
//			Console.WriteLine(x);

		}
	}
}
