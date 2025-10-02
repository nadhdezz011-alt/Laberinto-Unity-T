using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset = new Vector3(0, 10, -10);
   public Vector2 rotacion = new Vector2(45, 0);
    void LateUpdate()
    {
        if (jugador != null)
        {
            transform.position = jugador.position + offset + new Vector3(0, rotacion.x, 0);
            transform.LookAt(jugador);
        }
    }


}
