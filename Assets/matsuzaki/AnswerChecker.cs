using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    TMP_InputField answerInput;

    GameObject mondaiGroup;

    void Start()
    {
        answerInput = GameObject.Find("answer").GetComponent<TMP_InputField>();
        mondaiGroup = GameObject.Find("mondaiGroup");
    }

    void Update()
    {

    }

    public void CheckAnswer()
    {
        if (answerInput.text == "2")
        {
            mondaiGroup.SetActive(false);
        }
    }
}
