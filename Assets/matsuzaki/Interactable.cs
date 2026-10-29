using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject mondaiGroup;
    bool playerNearby = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("スペースキーが押された！");
        }

        if (playerNearby && Input.GetKeyDown(KeyCode.Space))
        {
            mondaiGroup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            Debug.Log("看板の判定に入った");
        }
    }
}
