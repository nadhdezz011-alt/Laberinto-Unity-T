using UnityEngine;

public class WallFunctionDetector : MonoBehaviour
{
    [SerializeField]
    Material muro;

    [SerializeField]
    Material MuroEnContacto;

    bool contacto = false;

    float tiempoEnContacto = 5f;
    private void Update()
    {
        if (contacto == true)
        { 
            tiempoEnContacto = tiempoEnContacto - Time.deltaTime;
            if (tiempoEnContacto <= 0)
            {
                gameObject.GetComponent<Renderer>().material = muro;
                contacto = false;
                tiempoEnContacto = 5f;

            }
        }


    }

    private void OnCollisionEnter(Collision coll)
    {
        
        if(coll.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material = MuroEnContacto;
            contacto = true;
        }
    }
}
