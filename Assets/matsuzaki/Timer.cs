using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    TMP_Text timeText;

    //ゲームオーバー
    public GameObject gameOverGroup;

    //主人公
    public GameObject player;
    Rigidbody2D playerRb;

    //タイマーストップ
    bool TimerStop = false;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();

        timer = Random.Range(150, 301); //150秒から300秒の間をランダム
        timeText = GetComponent<TMP_Text>();

        gameOverGroup.SetActive(false);
    }

    void Update()
    {
        if (!TimerStop && timer > 0)
        {
            timer -= Time.deltaTime;
            timeText.text = "時間：" + (int)timer + "秒";
        }
        else if (!TimerStop)
        {
            //ゲームオーバーを表示して主人公の動きを止める
            gameOverGroup.SetActive(true);

            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    public void StopTimer()
    {
        TimerStop = true;
    }
}
