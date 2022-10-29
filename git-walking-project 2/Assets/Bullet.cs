using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    float lifeTime = 0; // 計時秒數
    // Start is called before the first frame update
    void Start()
    {
        // 設定一個持續的方向力，往面對方向（forward = +z)
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 100;

    }

    // Update is called once per frame
    void Update()
    {
       // 計時三秒後刪除
        lifeTime += Time.deltaTime;
        if (lifeTime > 3)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            // 刪除物件(設為停用、並移除)
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
