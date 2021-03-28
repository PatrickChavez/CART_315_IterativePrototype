using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public Text textComponent;
    public float currentHealth = 100f;
    private static PlayerHealth original;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Constraining currenthealth
        currentHealth = Mathf.Clamp(currentHealth, 0, 100);

        textComponent.text = "Health: " + currentHealth.ToString();

        if (currentHealth <= 0)
        {
            // Code from JeanLuc
            // get the current scene name 
            string sceneName = SceneManager.GetActiveScene().name;

            // load the same scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

    //private void Awake()
    //{
    //    DontDestroyOnLoad(this.gameObject);
    //}

    // Code from Hellium
    private void Awake()
    {
        if (original != this)
        {
            if (original != null)
            {
                Destroy(original.gameObject);
            }
            DontDestroyOnLoad(gameObject);
            original = this;
        }
    }
}
