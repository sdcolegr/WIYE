using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class Dialog {

	private string _tag;
	private string _text;
	private List<Response> _responses;



	// Use getters and setters to disable setting!
	public string tag { get {return _tag; } set {}}
	public string text  { get {return _text; } set {}}
	public List<Response> responses  { get {return _responses; } set {}}


	//Constructors
	public Dialog(string tag, string text, List<Response> responses) {
		this._tag = tag;
		this._text = text;
		this._responses = responses;
	}


	[System.Serializable]
	public class Response {
		private string _text;
		private string _link;

		//Cannot set after created
		public string text { get {return _text;} set { } }
		public string link { get {return _link;} set { } }

		//Constructor
		public Response(string text, string link) {
			this._text = text;
			this._link = link;
		}
	}
}
