
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    private Rigidbody2D rb;
    private Vector2 moveInput;


    // カメラ内の移動範囲
    private Camera mainCamera;
    private float halfHeight;
    private float halfWidth;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;

        // キャラの大きさの半分を取得

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            halfWidth = sr.bounds.extents.x;
            halfHeight = sr.bounds.extents.y;
        }
    }

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x = -1f;
        if (Input.GetKey(KeyCode.D)) x = 1f;
        if (Input.GetKey(KeyCode.S)) y = -1f;
        if (Input.GetKey(KeyCode.W)) y = 1f;

        moveInput = new Vector2(x, y).normalized;
    }


    void FixedUpdate()
    {
        if (rb == null) return;

        Vector2 nextPosition =
            rb.position + moveInput * speed * Time.fixedDeltaTime;

        if (mainCamera != null)
        {
            float camHalfHeight = mainCamera.orthographicSize;
            float camHalfWidth = camHalfHeight * mainCamera.aspect;

            float minX = mainCamera.transform.position.x
                         - camHalfWidth + halfWidth;
            float maxX = mainCamera.transform.position.x
                         + camHalfWidth - halfWidth;

            float minY = mainCamera.transform.position.y
                         - camHalfHeight + halfHeight;
            float maxY = mainCamera.transform.position.y
                         + camHalfHeight - halfHeight;

            nextPosition.x = Mathf.Clamp(nextPosition.x, minX, maxX);
            nextPosition.y = Mathf.Clamp(nextPosition.y, minY, maxY);
        }

        rb.MovePosition(nextPosition);
    }

}
