using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleScene : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void LoadVehicleGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void LoadPlaneGame()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
