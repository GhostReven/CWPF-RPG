using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels {
	public class GameSession {
		public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

		public GameSession() {
			CurrentPlayer = new Player {
				Name = "Scott",
				CharacterClass = "Fighter",
				HitPoints = 10,
				Gold = 100000,
				ExperiencePoints = 0,
				Level = 1
			};

            CurrentLocation = new Location {
                Name = "Home",
                XCoordinate = 0,
                YCoordinate = 1,
                Description = "This is your house.",
                ImageName = "/CWPF-RPG;component/Images/Locations/Home.png"
            };
		}
	}
}
