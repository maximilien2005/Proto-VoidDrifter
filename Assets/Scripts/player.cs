using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D[] contacts;
    public CapsuleCollider2D maCapsule;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        maCapsule = GetComponent<CapsuleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Salle") ){
            Debug.Log(other.name);

            if (other.name == "SalleReserve") { }

            else if (other.name == "salleDefence") { }

            else if (other.name == "SalleRepos") { }

            else if (other.name == "") { }
        }

        
    }

}
