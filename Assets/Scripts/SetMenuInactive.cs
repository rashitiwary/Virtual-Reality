using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMenuInactive : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // public void inactiveMenu() 
    // {
    //     gameObject.SetActive(false);
    // }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
