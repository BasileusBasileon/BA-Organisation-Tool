using BA_Organisation_Tool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.ViewModels
{
	public class RunDetailPageViewModel
	{
		private BARun _run;

		public BARun Run
		{
			get => _run;
			set
			{
				_run = value;
			}
		}
		public List<Person> Leaders { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.GroupLeader)).Select(kvp => kvp.Key)); }
		public Person MainTank { get => _run.MainTank; }
		public List<Person> Refreshes { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Refresh)).Select(kvp => kvp.Key)); }
		public List<Person> Feints { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Feint)).Select(kvp => kvp.Key)); }
		public List<Person> Perceptions { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Perception)).Select(kvp => kvp.Key)); }
		public List<Person> Sacrifices { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Sacrifice)).Select(kvp => kvp.Key)); }
		public List<Person> Shells { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Shell)).Select(kvp => kvp.Key)); }
		public List<Person> Protects { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Protect)).Select(kvp => kvp.Key)); }
		public List<Person> Braveries { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.Bravery)).Select(kvp => kvp.Key)); }
		public List<Person> SpiritDarts { get => new List<Person>(_run.People.Where(kvp => kvp.Value.Roles.HasFlag(Roles.SpiritDart)).Select(kvp => kvp.Key)); }

		public RunDetailPageViewModel(BARun run)
		{
			Run = run;
		}
	}
}
