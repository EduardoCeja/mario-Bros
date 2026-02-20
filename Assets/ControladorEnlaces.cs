using UnityEngine;

public class ControladorEnlaces : MonoBehaviour
{
    public void AbrirURL(string url)
    {
        Application.OpenURL(url);
    }
}