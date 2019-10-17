using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] Text Score;
    public int score = 0;
    float maxValueTimer = 100;
    [SerializeField] Slider slider;
    [SerializeField] float sett = 5;



    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * ver * Time.deltaTime * speed);
        transform.Translate(Vector2.right * hor * Time.deltaTime * speed);

        slider.value -= Time.deltaTime * sett;
        if (slider.value <= 0)
        {
            slider.value = maxValueTimer;
            transform.position = Vector2.zero;
            score = 0;
            Score.text = "Score: " + score.ToString();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Score"))
        {
            Destroy(collider.gameObject);
            score++;
            Score.text = "Score: " + score.ToString();
            slider.value += Time.deltaTime * 500;

        }

        if (collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(collider.gameObject);
            score = 0;
            Score.text = "Score: " + score.ToString();
            transform.position = Vector2.zero;
            slider.value = 100;
        }
    }

}
