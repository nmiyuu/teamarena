
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    int life = 0;
    TMP_Text lifeText;
    //ゲームオーバー
    public GameObject gameOverGroup;
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
            //主人公の動きをとめる
            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            //タイマーを止める
            timer.StopTimer();
        }
    }

    public void Damage()
    {
        Debug.Log("Damage実行前：" + life);

        if (life > 0)
        {
            life--;
        }

        Debug.Log("Damage実行後：" + life);
    }
}
