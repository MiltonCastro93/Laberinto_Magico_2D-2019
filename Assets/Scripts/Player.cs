using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float Speed = 10f;
    public GameObject loser;
    public GameObject reintentar;
    private Rigidbody2D rb2;
    public GameObject camara;
    public bool tengoLlave = false;
    public Text Textollave;
    public Text Objetivo;

    void Start () {
        rb2 = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
	}

    public void Update() {
        if (tengoLlave) {
            Objetivo.text = "Busca La Puerta";
        }
    }

    private void LateUpdate() {
        if (tengoLlave) {
            Textollave.text = "Llave: 1 / 1";
        }

        camara.transform.rotation = Quaternion.Euler(Vector3.zero);
    }

    void FixedUpdate () {
        if (Input.GetKey(KeyCode.W)) {
            rb2.AddRelativeForce(new Vector3(1,0,0) * Speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb2.AddRelativeForce(new Vector3(-1, 0, 0) * Speed);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            transform.Rotate(new Vector3(0, 0, 90));
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            transform.Rotate(new Vector3(0, 0,- 90));
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Enemigo")) {
            loser.SetActive(true);
            reintentar.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
