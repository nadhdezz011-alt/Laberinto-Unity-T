using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjey;
    public float movimientoEjez;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimientoEjeX, movimientoEjey, movimientoEjez);
    }
}
