using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScene : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("gameselect");
    }
}
