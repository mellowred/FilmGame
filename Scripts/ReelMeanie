using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelMeanie : MonoBehaviour {

    private Rigidbody2D rigid;

    public GameObject player;
    public float moveSpeed;

    void Start () {
        rigid = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void Update () {
        Move ();
    }

    public void Move() {
        rigid.velocity = new Vector2(-moveSpeed, 0);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Wall") {
            moveSpeed *= -1;
        }
    }
}
