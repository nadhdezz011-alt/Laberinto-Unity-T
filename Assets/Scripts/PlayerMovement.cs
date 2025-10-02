using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    public float velocidad = 200f;
    
    
    
    void Update()
    {//input es para capturar las teclas de movimiento WASD o flechas 
        //getaxis es para capturar el movimiento en un eje (horizontal o vertical)
        //Time.deltaTime es para que el movimiento sea independiente del frame rate y se multiplica por la velocidad para ajustar la velocidad del movimiento
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        movimientoEjeX = - Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
        transform.Translate(movimientoEjeX, 0, movimientoEjeZ);
        //transform.Translate es para mover el objeto en el espacio 3D segun los ejes X, Y, Z es 0 porque no se mueve en Y
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");
        //Vector3 es una estructura que representa un vector en 3D con componentes X, Y, Z que sale en el inspector
        Vector3 direccion = new Vector3(vertical, 0f, horizontal);
        //if direccion es mayor a 0 es para normalizar la direccion cuando se mueve en diagonal
        if (direccion.magnitude > 0f)
        {
            direccion = direccion.normalized;
        }

        transform.Translate(direccion * velocidad * Time.deltaTime);
        //transfrom.translate direccion * velocidad * time.deltatime mueve
    }
}
