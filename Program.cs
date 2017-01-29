using System;
using System.Collections.Generic;

namespace TranslitMethod
{

	class Translit
	{
		static Dictionary <char, string> strings = new Dictionary<char, string>(); 

		static Translit()
		{
			strings.Add('а', "a");
			strings.Add('б',"b");
			strings.Add('в', "v");
			strings.Add('г', "g");
			strings.Add('д', "d");
			strings.Add('е', "e");
			strings.Add('ё', "e");
			strings.Add('ж', "j");
			strings.Add('з', "z");
			strings.Add('и', "i");
			strings.Add('й', "i");
			strings.Add('к', "k");
			strings.Add('л', "l");
			strings.Add('м', "m");
			strings.Add('н', "n");
			strings.Add('о', "o");
			strings.Add('п', "p");
			strings.Add('р', "r");
			strings.Add('с', "s");
			strings.Add('т', "t");
			strings.Add('у', "u");
			strings.Add('ф', "f");
			strings.Add('х', "h");
			strings.Add('ц', "c");
			strings.Add('ч', "ch");
			strings.Add('ш', "sh");
			strings.Add('щ', "sh");
			strings.Add('ъ', "'");
			strings.Add('ы', "y");
			strings.Add('ь', "'");
			strings.Add('э', "e");
			strings.Add('ю', "iu");
			strings.Add('я', "ia");
		}

		public static string TranslitString(string text)
		{
			string translitString = String.Empty ;


			for (int i = 0; i < text.Length; i += 1)
			{
				char key = text[i];
				char upperKey = Char.ToLower(key);

				if (Translit.strings.ContainsKey(key))
				{
					translitString += Translit.strings[key];
				}
				else if (Translit.strings.ContainsKey(upperKey))
				{
					translitString += Translit.strings[upperKey].ToUpper();
				}
				else
				{
					translitString += key;
				}
			}

			return translitString;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			string test = Translit.TranslitString("Просто тестовая строка. Метод TranslitString работает нормально.");
			Console.WriteLine(test);
			Console.ReadLine();
		}
	}
}
