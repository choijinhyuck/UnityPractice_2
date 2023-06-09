using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }
}
