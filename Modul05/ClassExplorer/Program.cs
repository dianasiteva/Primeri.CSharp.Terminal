using System;

namespace ClassExplorer
{

	public class person
	{

		private string _userName = "";            //променливи
		private string _userPass = "";

		private string _userID = "";
		private string _userFName = "";
		private string _userLName = "";

		public string userName                             //property
		{
			get { return _userName; }
		}

		public string userPass                            //property
		{
			get { return _userPass; }
		}

		public string userID                             //property
		{
			get { return _userID; }
			set { _userID = value; }
		}

		public string userFName                             //property
		{
			get { return _userFName; }
			set { _userFName = value; }
		}

		public string userLName                             //property
		{
			get { return _userLName; }
			set { _userLName = value; }
		}

		public person ( string _user, string _pass )          //входни параметри на класа person
				{
			checkUser ( _user, _pass );
				}




		private bool checkUser ( string _user, string _pass )     //метод
		{
			if ( _user == "user" && _pass == "pass" )
			{
				userName = _userName;
				userPass = _userPass;
				//Попълване на пропъртита
				_userID = "ID: 555";
				_userFName = "Diana";
				_userLName = "Siteva";
				return true;
			}
			return false;

		}


//		private string sipleString = "тестова променлива от клас";
//		private string user = "";
//
//		private string hiddenString = "";
//
//		public person ( string _ini )
//		{
//			
//			getUser ( _ini );
//			setwelcomeText ();
//
////			sipleString = "Промяна на тестовата променлива от клас.";
//		}
//
//		private void getUser ( string _ini )
//		{
//			if (_ini == "password1") hiddenString = "Потребител 1";
//			if (_ini == "password2") hiddenString = "Потребител 2";
//			user = hiddenString;
//		}
//
//		private void setwelcomeText ()
//		{
//			if (hiddenString.Length > 0)
//				sipleString = "Добре дошли отново, " + user + "!";
//			else
//				sipleString = "Вие нямате достъп до тази приграма!";
//		}
//
//		public string getwelcomeMassage ()
//		{
//			return sipleString;
//		}
//
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Потребител : ");
			string _user = Console.ReadLine();
			Console.Write ("Парола : ");
			string _pass = Console.ReadLine();
			//Дефиниране на клас
			person _person = new person ( _user, _pass );

			//Достъпване на клас
			Console.WriteLine ( _person.userFName + " " + _person.userLName);
			//			Console.WriteLine ( _person.getwelcomeMassage () );
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


//100 мравки се дуелират
//
//
//
//class Ant {
//
//	public double sila, kusmet, izdruzlivost, intelekt,nachalna_izdruzlivost;
//	public int nomer;
//	public string history;
//
//	public static Random rand = new Random();
//
//	public Ant(int _nomer ) {
//		nomer = _nomer;
//		sila = rand.Next(0,10);
//		kusmet = rand.Next(0,10);
//		izdruzlivost = rand.Next(0,10);
//		intelekt = rand.Next(0,10);
//		double koef = 40/(sila + kusmet + izdruzlivost + intelekt); // Искаме сумарно 4-рите характеристики да са 40точки.
//		sila *= koef;
//		kusmet *= koef;
//		izdruzlivost *= koef;
//		intelekt *= koef;
//		nachalna_izdruzlivost = izdruzlivost;
//
//	}
//
//	public double Attack( Ant opponent ) {
//		double score=0;
//
//		izdruzlivost += 3; // Преди всяка атака ще добавяме 3 издръжливост. 
//		if (izdruzlivost > nachalna_izdruzlivost) izdruzlivost = nachalna_izdruzlivost; // Ако издръжливостта е над началната, ще я намалим
//		if (izdruzlivost < 0) izdruzlivost = 0; // Ако е под нула ще я нулираме
//		if (rand.Next(0,10) < kusmet) score += 2; // Ако има късмет ще добавим 2 точки към атаката
//
//		score += sila/3; // атаката се увеличава със силата делено на 3
//		score *= izdruzlivost/30; // и се умножава по издръжливостта делена на 30
//
//		if (intelekt > opponent.intelekt) score *= 2; // Ако мравката е по-умна от другата, то умножаваме атаката по 2
//
//		opponent.izdruzlivost -= score*2; // Намаляваме издръжливостта на опонента спрямо атаката
//		return score;
//	}
//
//	public string print() {
//		return "(#"+nomer+" Из:"+izdruzlivost.ToString("#0")+" Ин:"+intelekt.ToString("#0")+" Кс:"+kusmet.ToString("#0")+" Сл:"+sila.ToString("#0")+")";
//	}
//
//
//}
//
//
//// Главният клас
//class MainClass {
//
//	// Главен метод на главния клас се пуска при стартиране на програмата
//	public static void Main() {
//		List<Ant> ants = new List<Ant>();
//		List<Ant> winners = new List<Ant>();
//
//		int i;
//
//		for (i=0; i< 128;i++) {
//			ants.Add( new Ant(i) );
//		}
//
//		Console.WriteLine("Турнаментът започва");
//		string history = "";
//		Ant atakuvasht, zashtitavasht;
//
//		double score1=0, score2=0;
//		do {
//			Console.WriteLine("В този кръг има "+ ants.Count+" Мравки");
//			for (i=0; i< ants.Count;i+=2) {
//
//				// Мравката с няй-голям късмет ще атакува първа
//				if (ants[i].kusmet > ants[i+1].kusmet) {
//					atakuvasht = ants[i];
//					zashtitavasht = ants[i+1];
//				} else {
//					atakuvasht = ants[i+1];
//					zashtitavasht = ants[i];
//				}    
//
//				score1 = atakuvasht.Attack( zashtitavasht );
//				score2 = zashtitavasht.Attack( atakuvasht );
//
//				history = "\n "+atakuvasht.print()+" атакува "+zashtitavasht.print();
//				atakuvasht.history += history;
//				zashtitavasht.history += history;
//				if (score1 > score2) {
//					winners.Add( atakuvasht );
//				} else {
//					winners.Add( zashtitavasht );
//				}
//			}
//
//			ants.Clear(); 
//			ants.AddRange(winners);
//			winners.Clear();
//
//		} while ( ants.Count > 1); 
//
//		Console.WriteLine("\nСпечелилата мравка е с номер "+ants[0].nomer);
//		Console.WriteLine("Интелект: "+ants[0].intelekt.ToString("#0.0"));
//		Console.WriteLine("Издръжливост в момента: "+ants[0].izdruzlivost.ToString("#0.0"));
//		Console.WriteLine("Начална издръжливост: "+ants[0].nachalna_izdruzlivost.ToString("#0.0"));
//		Console.WriteLine("Късмет: "+ants[0].kusmet.ToString("#0.0"));
//		Console.WriteLine("Сила: "+ants[0].sila.ToString("#0.0"));
//
//		Console.WriteLine("\nИсторията на мравката е:"+ ants[0].history+"\n");
//
//	}
//}