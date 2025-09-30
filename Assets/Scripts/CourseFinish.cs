using UnityEngine;

public class CourseFinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Debug.Log("Jugador ha llegado a la meta");
        }
    }
}
