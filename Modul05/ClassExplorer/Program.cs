using System;

namespace ClassExplorer
{

	public class person
	{
		public string sipleString = "тестова променлива от клас";
		public string user = "";

		private string hiddenString = "";

		public person ( string _ini )
		{
			if (_ini == "password1") hiddenString = "Потребител 1";
			if (_ini == "password2") hiddenString = "Потребител 2";

			user = hiddenString;

			if (hiddenString.Length > 0)
				sipleString = "Добре дошли отново, " + user + "!";
			else
				sipleString = "Вие нямате достъп до тази приграма!";

//			sipleString = "Промяна на тестовата променлива от клас.";
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Парола : ");
			string _user = Console.ReadLine();
			//Дефиниране на клас
			person _person = new person ( _user );

			//Достъпване на клас
			Console.WriteLine ( _person.sipleString );
		}
	}
}


//// Създаваме клас "човек"
//public class chovek {
//
//	// Всеки човек ще има "ime" и "godini". Това ще са свойства (properties) на всеки обект от класа chovek.
//	public string ime;
//	public int godini;
//
//	// Конструктора на нашия клас. Той приема параметри име, години и ги
//	// Поставя в свойствата на обекта достъпни от целия клас
//	public chovek(string _ime, int _godini) {
//		// _ime и _godini са локални променливи за този метод. Когато той свърши
//		// те ще бъдат изтрити. За това ще ги запишем в променливите/ свойствата ime и godini
//		// който са постоянни и достъпни от всички методи.
//
//		ime = _ime;
//		godini = _godini;
//	}
//
//	public void print() {
//		Console.WriteLine("Името ми е "+ime+" и съм на "+godini+" години");
//	}
//
//}
//
//// Главният клас
//class MainClass{
//
//	// Главен метод на главния клас се пуска при стартиране на програмата
//	public static void Main() {
//
//		// По същия начин по който дефинираме 'int' и 'string', 
//		// ще дефинираме променливите ivan,dragan, georgi 
//		// и ще ги инициализираме чрез конструкторите им
//		chovek ivan = new chovek("Иван", 23);
//
//		chovek dragan = new chovek("Драган", 33);
//
//		chovek georgi = new chovek("Георги", 45);
//
//		ivan.print();
//		dragan.print();
//		georgi.print();
//	}
//}




//public class Student {
//	public string ime;
//	public double ocenka;
//
//	public Student(string _ime, double _ocenka) {
//		ime = _ime;
//		ocenka = _ocenka;
//	}
//
//	public void print() {
//		Console.WriteLine("Студентът "+ime+" има оценка "+ocenka);
//	}
//
//}
//// Главният клас
//class MainClass{
//
//	// Главен метод на главния клас се пуска при стартиране на програмата
//	public static void Main() {
//		List<Student> grupa = new List<Student>();
//		grupa.Add( new Student("Иван", 4.5) );
//		grupa.Add( new Student("Петър", 3.5) );
//		grupa.Add( new Student("Гергана", 6.0) );
//
//		foreach(Student x in grupa) {
//			x.print();
//		}
//
//	}
//}