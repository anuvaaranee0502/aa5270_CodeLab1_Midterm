using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UtilScript : MonoBehaviour {

	public static string ReadStringFromFile (string path, string fileName){
		StreamReader sr = new StreamReader (path + "/" + fileName);
		string result = sr.ReadToEnd ();
		sr.Close ();

		return result;
	}
}
