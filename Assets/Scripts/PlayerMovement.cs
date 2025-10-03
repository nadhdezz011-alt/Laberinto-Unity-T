using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    public float velocidad = 200f;
    
    
    
    void Update()
    {
        /*movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        movimientoEjeX = - Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
        transform.Translate(movimientoEjeX, 0, movimientoEjeZ);*/
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");
        
        Vector3 direccion = new Vector3(vertical, 0f, horizontal);
       
        if (direccion.magnitude > 0f)
        {
            direccion = direccion.normalized;
        }

        transform.Translate(direccion * velocidad * Time.deltaTime);
        
    }
}
