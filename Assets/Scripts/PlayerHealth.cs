using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public Text textComponent;
    public float currentHealth;
    // Referencing the EnemyAttack script
    GameObject enemyAttackScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        textComponent.text = "Health: " + currentHealth.ToString();

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
