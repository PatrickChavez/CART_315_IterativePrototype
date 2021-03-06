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
                SceneManager.LoadScene("Ambush");
                this.transform.position = new Vector3(195f, 103f, 341f);
            }
        }
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
