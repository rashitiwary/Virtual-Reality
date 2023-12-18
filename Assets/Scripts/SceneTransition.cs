using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void StartSolarSystem()
    {
        // Load the "SolarSystem" scene when the "Start" button is pressed
        SceneManager.LoadScene("SolarSystem");
    }
}
