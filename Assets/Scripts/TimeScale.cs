﻿using UnityEngine;
using System.Collections;

public class TimeScale : MonoBehaviour {

    public float timeScale;

	public static string header = "Explore the Solar System!";
	public static string info = "Sun\nMercury\nVenus\nEarth\nMars";

	public GUIStyle styleHeader;

    void OnGUI()
    {
		styleHeader.fontSize = 20;
		styleHeader.fontStyle = FontStyle.Bold;
		styleHeader.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 20, 30, 20), new GUIContent("Time Scale"));
        timeScale = GUI.HorizontalSlider(new Rect(10, 40, 150, 40), timeScale, -4, 4);
        Time.timeScale = Mathf.Exp(timeScale);

		GUI.Label (new Rect (10, 100, 100, 30), new GUIContent(header), styleHeader);
		GUI.Label (new Rect (10, 120, 400, 400), new GUIContent(info));
    }
}
