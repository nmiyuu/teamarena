using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//再生モード終了
#else
        Application.Quit();
#endif
    }
}