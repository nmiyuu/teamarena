
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("罠に何かが触れた：" + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("プレイヤーに反応した！");

            Life lifeScript = FindObjectOfType<Life>();

            if (lifeScript != null)
            {
                lifeScript.Damage();
                Debug.Log("Damageを呼び出した！");
            }
            else
            {
                Debug.LogError("Lifeが見つからない！");
            }
        }
    }
}
