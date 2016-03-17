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
			int _ui = Convert.ToInt32 ( Console.ReadLine());

			bool _check01 = _ui <= _i.Length;
			bool _check02 = _ui > 0;

			bool ex1 = _check01 && _check02;   //логическо И
			bool ex2 = _check01 || _check02;   //логически ИЛИ
			bool ex3 = !_check01;              //отрицание 

			Console.WriteLine ("Логическо И: " + ex1.ToString());
			Console.WriteLine ("Логическо ИЛИ: " + ex2.ToString());
			Console.WriteLine ("Отрицание на " + _check01.ToString() + ": " + ex3.ToString());
		}
	}
}
