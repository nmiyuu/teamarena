using UnityEngine;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    
    public TMP_InputField answerInput;
    public Interactable interactable;
    //ゲームクリア
    public GameObject clearGroup;
    //主人公
    public GameObject player;
    Rigidbody2D playerRb;
    //タイマー
    public Timer timer;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    public void CheckAnswer()
    {
        if (answerInput.text == "金色" || answerInput.text == "きんいろ" || answerInput.text == "金" || answerInput.text == "きん")
        {
            interactable.CloseProblem();

            //ゲームクリア表示
            clearGroup.SetActive(true);

            //主人公の動きを止める
            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;

            //タイマーを止める
            timer.StopTimer();
        }
    }
}
