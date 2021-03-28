using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScript : MonoBehaviour
{
    private static DontDestroyScript original;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Code from Hellium
    private void Awake()
    {
        if (original !=this)
        {
            if (original != null)
            {
                Destroy(original.gameObject);
            }
            DontDestroyOnLoad(gameObject);
            original = this;
        }
        //DontDestroyOnLoad(this.gameObject);
    }
}
