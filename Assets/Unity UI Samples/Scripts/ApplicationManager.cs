using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1;
     
    void Start()
    {
        button1.onClick.AddListener(Quit);
    }

    void Quit () 
	{
		// UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

// using UnityEngine;
// using System.Collections;

// public class ApplicationManager : MonoBehaviour {
	

// 	public void Quit () 
// 	{
// 		#if UNITY_EDITOR
// 		UnityEditor.EditorApplication.isPlaying = false;
// 		#else
// 		Application.Quit();
// 		#endif
// 	}
// }
