using UnityEngine;

public class Timer : MonoBehaviour
{
    float timer = 0f;

    void Start()
    {
        timer = Random.Range(150, 301);
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
