using UnityEditor;
using UnityEngine;

public class CourseFinish : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Debug.Log("Jugador ha llegado a la meta");
            pantallaFinal.SetActive(true);
           other.GetComponent<PlayerMovement>().enabled = false;
            

        }
    }
}
