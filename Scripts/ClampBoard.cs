using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampBoard: MonoBehaviour {

    private Rigidbody2D rigid;

    public GameObject player;
    public float moveSpeed;

    public float minWaitTime = 5;
    public float maxWaitTime = 10;

    public float jumpForce = .5f;

    private bool jumping;
    private bool onGround;

    void Start () {
        rigid = this.GetComponent<Rigidbody2D>();
        StartCoroutine (JumpTimer());
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void Update () {
        Move ();
    }

    public void Move() {
        rigid.velocity = new Vector2(-moveSpeed, 0);
    }

    IEnumerator JumpTimer() {
        while (true) {
            yield return new WaitForSeconds (Random.Range (5, 10));
            Jump();
            Debug.Log ("Jump");
        }
    }

    public void Jump() {
        rigid.velocity = new Vector2(0, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Wall") {
            moveSpeed *= -1;
        }
    }
}
