using UnityEngine;
using System.Collections;

public class FPS_DemoScript : MonoBehaviour
{
	private string[] qualities;

	// Use this for initialization
	void Start ()
	{
		qualities=QualitySettings.names;

		FPSCounter.isOn=true;
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width*0.01f, Screen.height*0.9f, Screen.width*0.1f, Screen.height*0.05f), FPSCounter.isOn ? "ON" : "OFF"))
		{
			FPSCounter.isOn=!FPSCounter.isOn;
		}

		for (int i=0; i<qualities.Length; ++i)
		{
			if (GUI.Button(new Rect(Screen.width*0.01f, Screen.height*(0.05f+0.06f*i), Screen.width*0.1f, Screen.height*0.05f), i==QualitySettings.GetQualityLevel() ? (">>> "+qualities[i]+" <<<") : qualities[i]))
			{
				QualitySettings.SetQualityLevel(i);
			}
		}
	}
}
