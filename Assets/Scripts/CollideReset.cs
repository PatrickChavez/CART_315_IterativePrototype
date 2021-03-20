using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideReset : MonoBehaviour
{
    public GameObject player;

    private AudioSource deathSFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            deathSFX.Play();
            Debug.Log("Collision detected");
            SceneManager.LoadScene(0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        deathSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
