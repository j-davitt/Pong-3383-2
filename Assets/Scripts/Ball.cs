using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.67f;
    public float moveSpeed = 1f;
    public float maxStartY = 4f;

    private float startX = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitialPush();
    }

    void InitialPush()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = dir * moveSpeed;
    }

    void ResetBall()
    {
        float posY = Random.Range(-maxStartY,maxStartY);
        Vector2 pos = new Vector2(startX, posY);
        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
        if(scoreZone)
        {
            gameManager.OnScoreZoneReached(scoreZone.id);
            ResetBall();
            InitialPush();
        }
    }
}
