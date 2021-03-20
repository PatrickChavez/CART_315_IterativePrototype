using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeStart : MonoBehaviour
{
    public string mazestarttag;

    // Audio code from Statement and levelzerozilch 
    public AudioSource[] sounds;
    private AudioSource warpSFX;
    private AudioSource healSFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(mazestarttag))
        {
            Debug.Log("Start!");
            warpSFX.Play();
            //Destroy(collision.collider.gameObject);
            SceneManager.LoadScene("MazeCourse");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        warpSFX = sounds[0];
        healSFX = sounds[1];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
