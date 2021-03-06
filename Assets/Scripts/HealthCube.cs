using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCube : MonoBehaviour
{
    // Tutorials from WallaceT_MFM and antiquote 
    public GameObject player;
    public Text textComponent;
    public float healthGain = 1f;
    // Referencing the PlayerHealth script
    public GameObject playerHealthScript;
    private AudioSource healSFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("Health!");
            healSFX.Play();
            playerHealthScript.GetComponent<PlayerHealth>().currentHealth = playerHealthScript.GetComponent<PlayerHealth>().currentHealth + healthGain;
            Destroy(GetComponent<BoxCollider>());
            Destroy(this.gameObject, 0.5f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        healSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
