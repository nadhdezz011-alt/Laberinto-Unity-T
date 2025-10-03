using UnityEngine;
using TMPro;
public class SistemaRecoleccion : MonoBehaviour
{
    public int cantidadMonedas = 0;
    public TextMeshProUGUI numero;
    public TextMeshProUGUI numeroFinal;
    private void Start()
    {
        numero.text = cantidadMonedas.ToString();
        numeroFinal.text = cantidadMonedas.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneda"))
        {
            Destroy(other.gameObject);
            cantidadMonedas++;
            numero.text = cantidadMonedas.ToString();
            numeroFinal.text = cantidadMonedas.ToString();
        }

    }
}
