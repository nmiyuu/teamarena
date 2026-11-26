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

    //シーンごとに答えを変える
    public string[] Answer;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    public void CheckAnswer()
    {
        for (int i = 0; i < Answer.Length; i++)
        {
            if (answerInput.text == Answer[i])
            {
                //問題画面を閉じる
                interactable.CloseProblem();

                //ゲームクリア表示
                clearGroup.SetActive(true);

                //主人公の動きを止める
                playerRb.linearVelocity = Vector2.zero;
                playerRb.constraints = RigidbodyConstraints2D.FreezeAll;

                //タイマーを止める
                timer.StopTimer();

                break;
            }
        }
    }
}
