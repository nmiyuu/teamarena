using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ClickStartButton()
    {
        SceneManager.LoadScene("stage１");
    }
}

