using UnityEngine;
using UnityEngine.SceneManagement; // Esto es vital para cambiar escenas

public class Navegacion : MonoBehaviour
{
    // Función para ir a la segunda escena
    public void IrAEscenario2()
    {
        SceneManager.LoadScene("Escenario2"); 
    }

    // Función para regresar a la primera escena
    public void IrAInicio()
    {
        SceneManager.LoadScene("escena1"); 
    }
}