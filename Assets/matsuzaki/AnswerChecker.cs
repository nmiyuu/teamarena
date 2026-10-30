using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public TMP_InputField answerInput;
    public Interactable interactable;
    public GameObject clearGroup;

    public GameObject player;
    Rigidbody2D playerRb;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    public void CheckAnswer()
    {
        if (answerInput.text == "2")
        {
            interactable.CloseProblem();
            clearGroup.SetActive(true);

            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
