using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    [SerializeField] private Renderer backgroundRender; //variable para poner material de fondo
    public float scrollSpeed; //variable de la velocidad ene le que fondo se movera

    private void Update()
    {
        backgroundRender.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0); // metodo que permitira el movimiento de la textura de fondo 
    }
}
