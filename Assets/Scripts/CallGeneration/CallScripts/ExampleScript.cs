using UnityEngine;
using System.Collections;

public class ExampleScript : CallScript {
	int progress = 0;

	override public string getNextDialog() {
		int c = progress;
		progress++;

		switch (c) {
		case 0:
			return "My house is on fire.";
		case 1:
			return "My name is Jane Doe.";
		case 2:
			return "My adress is 555 Main St.";
		case 3:
			return "We are out of the house.";
		case 4:
			return "I dont know what else to say.";
		case 5:
			return "END";
		default:
			return "BROKE";
		}
	}
}
