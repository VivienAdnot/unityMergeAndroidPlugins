using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberExample : MonoBehaviour {
	public Text uiText;
	#if UNITY_ANDROID && !UNITY_EDITOR
	AndroidJavaClass pluginTestJavaClass;
	#endif

	// Use this for initialization
	void Start () {
		GameObject textGameObject = GameObject.Find ("Text");
		if (textGameObject == null) {
			Debug.LogError("vivien: Can't find text component");
		}

		uiText = textGameObject.GetComponent<Text> ();
		uiText.text = "start text ok";

		#if UNITY_ANDROID && !UNITY_EDITOR
		AndroidJNI.AttachCurrentThread ();
		pluginTestJavaClass = new AndroidJavaClass ("com.test.plugintest.MainActivity");
		#endif

		Debug.Log ("Finish start without error");
	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_ANDROID && !UNITY_EDITOR
		int number = pluginTestJavaClass.CallStatic<int> ("GetNumber");
		uiText.text = "number: " + number;
		#endif
	}
}
