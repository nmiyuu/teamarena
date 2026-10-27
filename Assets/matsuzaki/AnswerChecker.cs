using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    TMP_InputField answerInput;

    void Start()
    {
        answerInput = GameObject.Find("answer").GetComponent<TMP_InputField>();
    }

    void Update()
    {
        if (answerInput.text == "2")
        {

        }
    }
}
