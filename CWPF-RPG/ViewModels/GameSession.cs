using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace CWPF_RPG.ViewModels {
	class GameSession {
		Player CurrentPlayer { get; set; }

		public GameSession() {
			CurrentPlayer = new Player {
				Name = "Scott",
				Gold = 100000
			};
		}
	}
}
