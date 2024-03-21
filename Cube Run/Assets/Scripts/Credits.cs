using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        //Application.Quit();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
