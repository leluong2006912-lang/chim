using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;

    public float maxTime = 2f;

    public float height = 1.5f;

    float timer;

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        if (timer >= maxTime)
        {
            float y = transform.position.y + Random.Range(-height, height);

            Vector3 pos = new Vector3(transform.position.x, y, 0);

            GameObject tmp = Instantiate(pipe, pos, Quaternion.identity);

            Destroy(tmp, 8f);

            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
