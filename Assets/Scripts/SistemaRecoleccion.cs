using UnityEngine;
using TMPro;
public class SistemaRecoleccion : MonoBehaviour
{
    public int cantidadMonedas = 0;
    public TextMeshProUGUI numero;

    private void Update()
    {
        numero.text = cantidadMonedas.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneda"))
            {
            Destroy(other.gameObject);
            cantidadMonedas++;
        }
    }
}
