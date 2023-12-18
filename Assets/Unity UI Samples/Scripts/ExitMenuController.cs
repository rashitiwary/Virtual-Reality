// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ExitMenuController : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }

using UnityEngine;
using UnityEngine.InputSystem;

public class ExitMenuController : MonoBehaviour
{
    public GameObject exitMenu; // Reference to your exit menu GameObject

    private bool isExitMenuActive = false;

    private void Update()
    {
        if (Gamepad.current != null)
        {
            // Check if any button on the right controller was pressed this frame
            if (Gamepad.current.buttonSouth.wasPressedThisFrame || // Replace with the specific button(s) you want to use
                Gamepad.current.buttonWest.wasPressedThisFrame ||
                Gamepad.current.buttonNorth.wasPressedThisFrame ||
                Gamepad.current.buttonEast.wasPressedThisFrame)
            {
                // Toggle the exit menu on/off
                isExitMenuActive = !isExitMenuActive;
                exitMenu.SetActive(isExitMenuActive);
            }
        }
    }
}
