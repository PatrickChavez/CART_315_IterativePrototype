using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalPickup : MonoBehaviour
{
    public string pickuptag;
    public Text textComponent;
    int score = 0;
    private AudioSource goalSFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(pickuptag))
        {
            Debug.Log("Nice one!");
            goalSFX.Play();
            Destroy(collision.collider.gameObject);

            score = score + 1;
            textComponent.text = "Cubes: " + score;

            if (score == 4)
            {
                SceneManager.LoadScene("Crater");
            }
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        goalSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
