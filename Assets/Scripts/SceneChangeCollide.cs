using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeCollide : MonoBehaviour
{
    public string chosenScene;
    //public GameObject player;
    public string scenetag;
    public Vector3 playerPosition = new Vector3(195f, 103f, 341f);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(scenetag))
        {
            Debug.Log("Scene change!");
            SceneManager.LoadScene(chosenScene);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
