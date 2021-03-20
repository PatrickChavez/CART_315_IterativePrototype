using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{
    // Tutorials from WallaceT_MFM and antiquote 
    public GameObject player;
    public Text textComponent;
    public float enemyDamage = 1f;
    // Referencing the PlayerHealth script
    public GameObject playerHealthScript;
    private AudioSource attackSFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            attackSFX.Play();
            playerHealthScript.GetComponent<PlayerHealth>().currentHealth = playerHealthScript.GetComponent<PlayerHealth>().currentHealth - enemyDamage;
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        attackSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
