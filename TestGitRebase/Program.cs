using System;

namespace TestGitRebase
{
	class Program
	{
		static void Main(string[] args)
		{
			JSribar();
			JSribar1();
			LGregoric();
			BRados();
			PPavicic();
			ISpanja();
			RHaramincic();
			VCagalj();
			ABrkic();
			AVrljic();
			AJuric();
			MKocelj();
			ISokolovic();
			IMidzic();
			KPogacic();
		}



        static void JSribar()
        {
            Console.WriteLine("My name is Julijan Šribar");
            Console.WriteLine("I live in Zagreb");
            Console.WriteLine("I was born in Brežice");
            Console.WriteLine("My favorite movie is 'Who's singing there'");
            Console.WriteLine("Something");
            Console.WriteLine("My favorite food are pancakes");

            JSribarClass.Present();
        }

		static void JSribar1()
		{
			Console.WriteLine("My name is Julijan1 Šribar1");
		}

		static void LGregoric()
		{
			Console.WriteLine("My name is Luka Gregorić");
			Console.WriteLine("I do not live in Zagreb.");
			Console.WriteLine("I was born in Zagreb.");
			Console.WriteLine("My favourite movie is Inglorious Basterds.");
		}

        static void BRados()
        {
            Console.WriteLine("My name is Branko Rados");
            Console.WriteLine("I live in Zagreb");
            Console.WriteLine("I was born in Zagreb");
            Console.WriteLine("My favorite movie is Duga mracna noc");
            Console.WriteLine("My favorite food is lamb");
        }

		static void PPavicic()
		{
			Console.WriteLine("My name is Pavle Pavičić");
			Console.WriteLine("I live in Sveta Nedelja");
			Console.WriteLine("I was born in Zagreb");
			Console.WriteLine("My favorite movie is Django Unchained");
		}
		static void ISpanja()
		{
			Console.WriteLine("My name is Ivan Schpanja");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Sibenik");
			Console.WriteLine("My favourite movie is Who's singing there");
			Console.WriteLine("My favorite food are pancakes");

			ISpanjaClass.Present();
		}

        static void RHaramincic()
        {
            Console.WriteLine("My name is Robert Haraminčić");
            Console.WriteLine("Staying alive in Velika Gorica!");
            Console.WriteLine("Born in Zagreb!");
            Console.WriteLine("My favorite movie is Jahali pješice");
            Console.WriteLine("My favorite food is burger");

            RHaramincicClass.Present();
        }

		static void VCagalj()
		{
			Console.WriteLine("My name is Vicko Čagalj");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Split");
			Console.WriteLine("My favorite movie is Lord of the Rings: The Return of the King");
		}

		static void ABrkic()
		{
			Console.WriteLine("My name is Antonio Brkić");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Zadar");
			Console.WriteLine("My favorite movie is Limitless");
		}

		static void AVrljic()
		{
			Console.WriteLine("My name is Andrea Vrljic");
			Console.WriteLine("I do not live in Zagreb.");
			Console.WriteLine("I was born in Slavonski Brod.");
			Console.WriteLine("I do not have favourite movie");
		
		}

		static void AJuric()
		{
			Console.WriteLine("My name is Anđela Jurić");
			Console.WriteLine("I live in Zagreb.");
			Console.WriteLine("I was born in Zadar.");
			Console.WriteLine("My favourite movie is Little women.");
		}

		static void MKocelj()
		{
			Console.WriteLine("My name is Mato Kocelj");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Dubrovnik");
			Console.WriteLine("My favorite movie is Who");
			Console.WriteLine("My favourite food is pršut");

            MKoceljClass.Present();
		}

		static void ISokolovic()
		{
			Console.WriteLine("My name is Ivan Sokolović");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Zagreb");
			Console.WriteLine("My favorite movie is Sharknado 6");
		}

		static void IMidzic()
		{
			Console.WriteLine("My name is Ida Midžić");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Zadar");
			Console.WriteLine("My favorite movie is Alien vs. Predator");
		}
	
	    static void KPogacic()
		{
			Console.WriteLine("My name is Kata Pogacic");
			Console.WriteLine("I live in Zagreb");
			Console.WriteLine("I was born in Split");
			Console.WriteLine("My favourite movie is...");
		}
	}
}
