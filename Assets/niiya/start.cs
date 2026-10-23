
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void MoveScene(string gameselect)
    {
        SceneManager.LoadScene(gameselect);
    }
}
