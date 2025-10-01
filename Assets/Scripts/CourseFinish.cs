using UnityEditor;
using UnityEngine;
using TMPro;

public class CourseFinish : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoDePartida = 0.0f;
    bool estajugando = true;
    private void Update()
    {
        if (estajugando)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Debug.Log("Jugador ha llegado a la meta");
            pantallaFinal.SetActive(true);
           other.GetComponent<PlayerMovement>().enabled = false;
            estajugando = false;
            textLabelTime.text = tiempoDePartida.ToString();
        }
    }
}
