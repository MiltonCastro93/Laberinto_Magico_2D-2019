using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victoria : MonoBehaviour {
    public GameObject winner;
    public GameObject irmenu;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            winner.SetActive(true);
            Time.timeScale = 0;
            irmenu.SetActive(true);
        }
    }
}
