using System;

namespace RD - uporabnik {
	public class User {
		private int id;
		private String username;
		private String password;
		private Configuration personalConfiguration;
		private List<Game> favoriteGames;
		private History history;

		public void SetGeslo(ref String password) {
			throw new System.NotImplementedException("Not implemented");
		}
		public User GetUser() {
			throw new System.NotImplementedException("Not implemented");
		}

		private Configuration 1;
		private Game 0..n;
		private History 0..1;

	}

}
