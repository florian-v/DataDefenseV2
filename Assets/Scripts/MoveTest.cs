using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Hashtable options = iTween.Hash(
			"path", iTweenPath.GetPath ("TestPath"),
			"time", 5,
			"easetype", iTween.EaseType.linear
			);
		iTween.MoveTo (gameObject, options);
		//iTween.MoveTo (gameObject, iTween.Hash ("path", iTweenPath.GetPath ("TestPath"), "time", 5));
	}
}
