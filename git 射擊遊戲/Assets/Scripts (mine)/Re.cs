using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.name == "sus") 
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
