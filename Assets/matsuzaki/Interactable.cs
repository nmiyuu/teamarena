using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject mondaiGroup;
    public GameObject player;

    bool playerNearby = false;
    bool isShowing = false;

    Rigidbody2D playerRb;
    SpriteRenderer playerSprite;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        playerSprite = player.GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.Space))
        {
            isShowing = true;
            mondaiGroup.SetActive(true);

            // ålŒö‚Ì“®‚«‚ğ~‚ß‚é
            playerRb.linearVelocity = Vector2.zero;
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            playerSprite.enabled = false;
        }
    }

    public void CloseProblem()
    {
        isShowing = false;
        mondaiGroup.SetActive(false);

        // ålŒö‚Ì“®‚«‚ğÄŠJ‚·‚é
        playerSprite.enabled = true;
        playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    //‹ß‚Ã‚¢‚½‚Æ‚«
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    //—£‚ê‚½‚Æ‚«
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}
