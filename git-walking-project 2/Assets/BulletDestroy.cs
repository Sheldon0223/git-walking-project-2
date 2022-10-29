using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
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
        if (other.gameObject.tag == "Enemy")
        {
            // 刪除物件(設為停用、並移除)
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

              GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");

        }
    }
}
