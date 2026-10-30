
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    int life = 0;
    TMP_Text lifeText;

    public GameObject gameOverGroup;

    public GameObject player;
    Rigidbody2D playerRb;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();


        life = Random.Range(1, 6);
        lifeText = GetComponent<TMP_Text>();

        gameOverGroup.SetActive(false);

        Debug.Log(lifeText == null ? "テキスト取得失敗" : "テキスト取得成功");
    }
    void Update()
    {
        lifeText.text = "体力：" + life;

        if (life <= 0)
        {
            gameOverGroup.SetActive(true);

            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
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
