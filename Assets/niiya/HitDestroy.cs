using UnityEngine;
public class HitDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 当たった相手のタグがPlayerかどうかを判定
        if ((collision.gameObject.tag == "Player"))
        {
            // Playerであれば自分自身を2秒後に削除
            Destroy(this.gameObject,0.3f);
        }
    }
}