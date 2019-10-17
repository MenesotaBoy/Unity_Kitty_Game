using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour {

    private Vector2 newPos;
    [SerializeField] Transform Player;
    [SerializeField] GameObject Score;
    [SerializeField] GameObject Enemy;
    float timer = 0.5f;
    float random;
    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {

            GenerateNewPosition();

            while (Vector2.Distance(newPos, Player.position) < 2.5f || Vector2.Distance(newPos, Player.position) > 9)
            {
                GenerateNewPosition();
            }

            float randomValue = Random.Range(0, 100);
            if (randomValue < 60)
                Instantiate(Score, newPos, Quaternion.identity);
            else
                Instantiate(Enemy, newPos, Quaternion.identity);

            timer = Random.Range(1.1f, 2f);
        }

    }


    private void GenerateNewPosition()
    {
        newPos.x = transform.position.x + Random.Range(-15, 15);
        newPos.y = transform.position.y + Random.Range(-15, 15);
    }
}
