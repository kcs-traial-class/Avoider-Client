using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            move += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move += Vector2.right;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);

        // 画面の端で移動制限（-7〜7 に調整可能）
        float clampedX = Mathf.Clamp(transform.position.x, -7f, 7f);
        transform.position = new Vector2(clampedX, transform.position.y);
    }
}
