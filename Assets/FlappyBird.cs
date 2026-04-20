using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    Rigidbody2D rg;

    public float speed = 200f;

    public GameObject gameOverobj;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
        }
    }

    public void ResetGame()
    {
        Time.timeScale = 1f; // Phai reset lai toc do thoi gian
        SceneManager.LoadScene(0);
    }

    void GameOver()
    {
        gameOverobj.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
