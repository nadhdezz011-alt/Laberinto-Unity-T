using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    public float velocidad = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input es una clase que permite obtener la entrada del usuario (teclado, mouse, joystick, etc) 
        //GetAxis es un metodo que permite obtener el valor de un eje (Horizontal, Vertical, etc)
        //Time.deltaTime es el tiempo que ha pasado desde el ultimo frame (se usa para que el movimiento sea independiente del frame rate)
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime;
        movimientoEjeX = - Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
        //transform es la posicion del objeto en el espacio
        //translate es para mover el objeto en el espacio
        //(movimientoEjeX, movimientoEjey, movimientoEjez) son las variables que se usan para mover el objeto en el espacio

    }
}
