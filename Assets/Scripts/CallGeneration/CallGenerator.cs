using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class CallGenerator : MonoBehaviour {
	public int current = 0; // our current position in the sequence
	public int storyPos = 0;
	public int[] sequence = new int[]{1,2,3}; // The sequence of non story calls between story calls, example {1,3,2} means that 1 non story call has to happen before the next story one, then 3, then 2
	public CallScript[] randomCalls = new CallScript[]{new ExampleScript()}; // List of non story calls
	public CallScript[] storyCalls = new CallScript[]{new ExampleScript()}; // list of story calls, IN ORDER

	public CallScript getNextCall() {
		//[TODO] Make it so random calls cannot be repeated
		if (sequence[current] > 0) {
			int r = Mathf.RoundToInt(Random.value * (randomCalls.Length-1)); // get the number for a random call
			sequence[current]--; // decrese the number of calls we need to do still
			CallScript ret = randomCalls[r];
			return ret; // return the random call
		}
		else {
			current++; // increase our sequence thing
			return storyCalls[storyPos++]; // Return the next story script
		}
	}
}
