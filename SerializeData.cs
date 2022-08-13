using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace WpfAppProject
{
	static class SerializeData
	{
		public static void SerializeSave()
		{
			var lizards1 = new List<seats>();
			lizards1.Add(new seats(1, "Louis"));
			lizards1.Add(new seats(2, "Louis"));
			var lizards2 = new List<seats>();
			lizards2.Add(new seats(18, "Zayn"));
			lizards2.Add(new seats(23, "Zayn"));
			lizards2.Add(new seats(22, "Zayn"));
			var lizards3 = new List<seats>();
			lizards3.Add(new seats(5, "Rehan"));
			lizards3.Add(new seats(6, "Rehan"));
			lizards3.Add(new seats(7, "Rehan"));
			var lizards4 = new List<seats>();
			lizards4.Add(new seats(15, "Sara"));
			lizards4.Add(new seats(17, "Sara"));
			lizards4.Add(new seats(19, "Sara"));
			var lizards5 = new List<seats>();
			lizards5.Add(new seats(9, "Obama"));
			lizards5.Add(new seats(10, "Obama"));

			var lizards6 = new List<seats>();
			lizards6.Add(new seats(20, "Yasir"));


			try
			{
				using (Stream stream = File.Open("data.bin", FileMode.Create))
				{
					BinaryFormatter bin = new BinaryFormatter();
					bin.Serialize(stream, lizards1);
					bin.Serialize(stream, lizards2);
					bin.Serialize(stream, lizards3);
					bin.Serialize(stream, lizards4);
					bin.Serialize(stream, lizards5);
					bin.Serialize(stream, lizards6);
				}
			}
			catch (IOException)
			{
			}
		}
		public static List<Personcs> Deserialize()
		{
			List<Personcs> people = new List<Personcs>();
			try
			{
				using (Stream stream = File.Open("data.bin", FileMode.Open))
				{
					BinaryFormatter bin = new BinaryFormatter();

					for (int i = 0; i < 6; i++)
					{
						var lizardsk = (List<seats>)bin.Deserialize(stream);

						Personcs obj = new Personcs();
						foreach (seats lizard in lizardsk)
						{

							obj.name = lizard.name;
							obj.seats.Add(lizard.value);

						}
						people.Add(obj);

					}
				}
			}
			catch (IOException)
			{
			}


			return people;

		}
	}
}
