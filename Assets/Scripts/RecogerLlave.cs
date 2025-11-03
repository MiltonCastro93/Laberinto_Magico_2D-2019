using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerLlave : MonoBehaviour {
    private AudioSource musica;
    private float tiempomusica = 0;

    private void Start() {
        musica = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if ((collision.CompareTag("Player"))) {
            collision.GetComponent<Player>().tengoLlave = true;
            musica.Play();
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        tiempomusica += Time.deltaTime;
        if (collision.CompareTag("Player")) {
            if(tiempomusica >= 0.5f) {
                musica.Stop();
                Destroy(gameObject);
            }
        }
    }
}
