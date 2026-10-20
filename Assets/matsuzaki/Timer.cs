using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer = 0f;
    TMP_Text timeText;

    void Start()
    {
        timer = Random.Range(150, 301); //150•b‚©‚ç300•b‚ÌŠÔ‚ğƒ‰ƒ“ƒ_ƒ€
        timeText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timeText.text = "ŠÔF" + (int)timer + "•b";
        }
    }
}
