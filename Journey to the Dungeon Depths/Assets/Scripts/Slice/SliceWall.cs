using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceWall : MonoBehaviour {
    private SpriteRenderer sprite;

    private bool detecting = true;
    private new BoxCollider2D collider;
    private int cooldown = 10;

    private Slice slice;

    private void Start() {
        collider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        slice = Slice.instance;

        Slice.finishAttack.AddListener(ResetCollision);
    }

    private void Update() {
        if (cooldown > 0) {
            cooldown--;
            if (cooldown <= 0) {
                detecting = true;
                sprite.color = Color.white;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Slice") && detecting) {
            detecting = false;
            sprite.color = Color.red;
            ContactPoint2D[] contacts = new ContactPoint2D[1];
            other.GetContacts(contacts);

            slice.SetAttack(contacts[0].point);
        }
    }

    private void ResetCollision() {
        cooldown = 10;
    }
}
