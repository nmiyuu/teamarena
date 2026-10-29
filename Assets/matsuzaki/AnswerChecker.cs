using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public TMP_InputField answerInput;
    public Interactable interactable;
    public GameObject clearText;

    public void CheckAnswer()
    {
        if (answerInput.text == "2")
        {
            interactable.CloseProblem();
            clearText.SetActive(true);
        }
    }
}
