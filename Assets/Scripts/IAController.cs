using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAController : MonoBehaviour {
    public GameObject player;
    public GameObject[] Puntos;
    public ParticleSystem efecto;
    public AudioClip[] musicaEstados;
    private AudioSource As;
    private Rigidbody2D rb;
    private float pasaje = 0;
    private bool EstadoPatrullando = true;
    public bool irB = true;

    public enum Estados { Patrulla,Encontrado,Persecucion,Busqueda};
    public Estados Myestado;

	void Start () {
        As = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        switch (Myestado) {
            case Estados.Patrulla:
                estoyPatrullando();
                efecto.Stop();
                break;
            case Estados.Encontrado:
                EstadoPatrullando = false;
                break;
            case Estados.Persecucion:
                break;
            case Estados.Busqueda:
                pasarestado();//pasar de este estado al Patrulla
                break;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Myestado = Estados.Encontrado;//iniciar el estado "detectado"
            player = collision.gameObject;//obtener el player
            As.Play();
        }
    }
    void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Myestado = Estados.Persecucion;//iniciar estado de persecucion
            transform.rotation = Quaternion.LookRotation(Vector3.forward, player.transform.position - transform.position);
            //transform.up = player.transform.position - transform.position;
            SeguirAlJugador();
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Myestado = Estados.Busqueda;
        }
    }

    private void pasarestado(){
        pasaje += Time.deltaTime;
        As.clip = musicaEstados[0];
        As.loop = false;
        As.Stop();
        if (pasaje >= 5f) {
            efecto.Play();
            if (pasaje >= 15f) {
                pasaje = 0;
                Myestado = Estados.Patrulla;
                teletransporte();
            }
        }
    }
    
    private void teletransporte() {
        transform.position = Puntos[0].transform.position;
        EstadoPatrullando = true;
        irB = true;
        transform.rotation = Quaternion.Euler(0, 0, 270);
    }

    private void estoyPatrullando() {
        if (EstadoPatrullando) {
            if (irB) {
                if (transform.position.x >= Puntos[1].transform.position.x) {
                    irB = false;
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                } else {
                    rb.AddForce(Vector3.right * 1f);
                }
            } else {
                if (transform.position.x <= Puntos[0].transform.position.x) {
                    irB = true;
                    transform.rotation = Quaternion.Euler(0, 0, 270);
                } else {
                    rb.AddForce(Vector3.left * 1f);
                }
            }

        }

    }

    private void SeguirAlJugador() {
        As.clip = musicaEstados[1];
        As.loop = true;
        As.Play();
        efecto.Stop();
        if(transform.position.x <= player.transform.position.x) {
            rb.AddForce(Vector3.right * 0.5f);
        } else {
            rb.AddForce(Vector3.left * 0.5f);
        }
        if (transform.position.y <= player.transform.position.y) {
            rb.AddForce(Vector3.up * 0.5f);
        } else {
            rb.AddForce(Vector3.down * 0.5f);
        }
    }

}
//            transform.rotation = Quaternion.LookRotation(Vector3.forward, player.transform.position - transform.position);