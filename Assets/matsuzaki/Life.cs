using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    int life = 0;
    TMP_Text lifeText;
    //ゲームオーバー
    public GameObject gameOverGroup;
    //ゲームオーバー時にいらない表示を消すのにメッセージ
    public GameObject ExitMessage;
    public GameObject AppleMessage;

    //主人公
    public GameObject player;
    Rigidbody2D playerRb;
    //タイマー
    public Timer timer;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();


        life = Random.Range(1, 6);
        lifeText = GetComponent<TMP_Text>();

        gameOverGroup.SetActive(false);
    }
    void Update()
    {
        lifeText.text = "体力：" + life;

        if (life <= 0)
        {
            //ゲームオーバー表示
            gameOverGroup.SetActive(true);

            //メッセージ系が表示されていたら消す
            ExitMessage.SetActive(false);
            AppleMessage.SetActive(false);

            //主人公の動きをとめる
            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            //タイマーを止める
            timer.StopTimer();
        }
    }

    public void Damage()
    {
        if (life > 0)
        {
            life--;
        }
    }
}
