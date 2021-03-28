using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeCollide : MonoBehaviour
{
    public string chosenScene;
    public GameObject player;
    public Vector3 playerPosition = new Vector3(0, 2.0f, 0);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("Scene change!");
            SceneManager.LoadScene(chosenScene);
            player.transform.position = playerPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
