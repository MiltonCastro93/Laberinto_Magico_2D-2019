using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CondicionCompleta1 : MonoBehaviour {
    public Text Objetivo;
    public Text contadorLlave;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player")) {
            if (collision.collider.GetComponent<Player>().tengoLlave) {
                collision.collider.GetComponent<Player>().tengoLlave = false;
                Objetivo.text = "Ve al Portal!";
                contadorLlave.text = "Llave: 0 / 1";
                Destroy(gameObject);
            }
        }
    }
}
