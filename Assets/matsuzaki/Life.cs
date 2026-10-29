
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    int life = 0;
    TMP_Text lifeText;

    void Start()
    {
        life = Random.Range(0, 6);
        lifeText = GetComponent<TMP_Text>();

        Debug.Log(lifeText == null ? "テキスト取得失敗" : "テキスト取得成功");
    }
    void Update()
    {
        lifeText.text = "残機：" + life;
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
