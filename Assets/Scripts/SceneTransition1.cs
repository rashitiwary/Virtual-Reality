using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1;
     
    void Start()
    {
        button1.onClick.AddListener(taskonclick);
    }

    void taskonclick() 
    {
        Application.LoadLevel("SolarSystem");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
