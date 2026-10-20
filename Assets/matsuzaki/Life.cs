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
    }

    void Update()
    {
        lifeText.text = "écã@ÅF" + life;
    }
}
