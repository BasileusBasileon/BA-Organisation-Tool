using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
	public class BARun
	{
		private Dictionary<Person, PersonRunInformation> _people = new Dictionary<Person, PersonRunInformation>();

		private bool? _clearedArtOwain;
		private bool? _clearedRaiden;
		private bool? _clearedAV;
		private bool? _clearedOzma;

		private bool _runOver;

		public Person Leader { get => _people.First(kvp => kvp.Value.Roles.HasFlag(Roles.BALeader)).Key; }
		public Person MainTank { get => _people.First(kvp => kvp.Value.Roles.HasFlag(Roles.MainTank)).Key; }
		public Dictionary<Person, PersonRunInformation> People { get => _people; }

		public bool? ClearedArtOwain { get => _clearedArtOwain; set => _clearedArtOwain = value; }
		public bool? ClearedRaiden { get => _clearedRaiden; set => _clearedRaiden = value; }
		public bool? ClearedAV { get => _clearedAV; set => _clearedAV = value; }
		public bool? ClearedOzma { get => _clearedOzma; set => _clearedOzma = value; }

		public bool RunOver { get => _runOver; set => _runOver = value; }

		public BARun(IEnumerable<(Person, PersonRunInformation)> people)
		{
			foreach ((Person, PersonRunInformation) pair in people)
			{
				People.Add(pair.Item1, pair.Item2);
			}
		}

		internal static BARun CreateSample()
		{
			List<(Person, PersonRunInformation)> people = new List<(Person, PersonRunInformation)>();

			// Leaders
			people.Add((new Person { IgName = "Ese" }, new PersonRunInformation { Group = GroupEnum.Logos1, Roles = Roles.BALeader | Roles.GroupLeader | Roles.HealerShield | Roles.Sacrifice }));
			people.Add((new Person { IgName = "Zal" }, new PersonRunInformation { Group = GroupEnum.Logos2, Roles = Roles.GroupLeader | Roles.MainTank }));
			people.Add((new Person { IgName = "Vega" }, new PersonRunInformation { Group = GroupEnum.Logos3, Roles = Roles.GroupLeader | Roles.DD | Roles.Bravery }));
			people.Add((new Person { IgName = "Saki" }, new PersonRunInformation { Group = GroupEnum.Magia1, Roles = Roles.GroupLeader | Roles.HealerRegen | Roles.Refresh }));
			people.Add((new Person { IgName = "Taishelo" }, new PersonRunInformation { Group = GroupEnum.Magia2, Roles = Roles.GroupLeader | Roles.DD | Roles.BlueDPS }));
			people.Add((new Person { IgName = "Gaius" }, new PersonRunInformation { Group = GroupEnum.Magia3, Roles = Roles.GroupLeader | Roles.DD | Roles.SpiritDart })); // What a Nerd
			people.Add((new Person { IgName = "Tzaru" }, new PersonRunInformation { Group = GroupEnum.Support, Roles = Roles.GroupLeader | Roles.Tank | Roles.Sacrifice }));

			// Normal Members

			return new BARun(people);
		}
	}
}
