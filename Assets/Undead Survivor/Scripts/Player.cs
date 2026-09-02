using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVector;   
    public float speed; 
    Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxisRaw("Horizontal");
        inputVector.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 nextVector = inputVector.normalized * speed * Time.fixedDeltaTime;
        // 3. 위치 이동 
        rigid.MovePosition(rigid.position + nextVector);
    }
}
