using Unity.VisualScripting;
using UnityEngine;

public class Message : MonoBehaviour
{
    public GameObject messageGroup;
    
    //最初は非表示
    void Start()
    {
        messageGroup.SetActive(false);
    }

    //プレイヤータグを持つプレイヤーが範囲に入ると表示
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageGroup.SetActive(true);
        }
    }

    //離れたら非表示
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageGroup.SetActive(false);
        }
    }
}
