using System;

namespace RD - uporabnik {
	public class Component {
		private int id;
		private String brand;
		private String name;
		private String base64Image;
		/// <summary>
		/// Is an integer that represents times used. Bigger the number, bigger the popularity
		/// </summary>
		private int popularity;

		public Component GetComponent() {
			throw new System.NotImplementedException("Not implemented");
		}
		public String GetImage() {
			throw new System.NotImplementedException("Not implemented");
		}
		public int GetPopularity() {
			return this.popularity;
		}

	}

}
