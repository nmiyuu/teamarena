using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public TMP_InputField answerInput;
    public Interactable interactable;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void CheckAnswer()
    {
        if (answerInput.text == "2")
        {
            interactable.CloseProblem();
        }
    }
}
