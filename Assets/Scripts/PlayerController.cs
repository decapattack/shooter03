using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Captura os eixos do teclado (WSAD / Setas)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // 2. Cria um vetor de direção (X, Y, Z)
        // No 3D, o plano de chão é X e Z. O Y é altura.
        Vector3 direction = new Vector3(moveX, 0, moveZ);

        // 3. Move o objeto no espaço
        // transform.Translate move o objeto em relação ao seu próprio eixo
        // Time.deltaTime garante que a velocidade seja por segundo, não por frame
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
