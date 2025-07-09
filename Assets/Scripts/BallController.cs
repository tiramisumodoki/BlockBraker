using UnityEngine;
using UnityEngine.SceneManagement;
public class BallController : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

        	// ボールの初期方向をランダムに設定
        	Vector2 initialDirection = new Vector2(Random.Range(-2f, 2f), 2).normalized;
        	rb.linearVelocity = initialDirection * speed;	
    	}

	void Update()
	{
        if (transform.position.y < -10f)
        	{
		rb.linearVelocity = Vector2.zero;     	// 速度を0にする
        	SceneManager.LoadScene("GameoverScene");
		}
     	}
	
}