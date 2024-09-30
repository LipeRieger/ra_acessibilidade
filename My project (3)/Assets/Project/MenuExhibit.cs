using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuExhibit : MonoBehaviour
{
    public Transform player;
    public float distanciaJogador = 3.0f;
    public GameObject menu;
    public InputActionProperty exibirBotao;

    // Atualização por frame
    void Update()
    {
        if (exibirBotao.action.WasPressedThisFrame())
        {
            // Alterna visibilidade do menu
            menu.SetActive(!menu.activeSelf);

            // Atualiza a posição do menu à frente do jogador
            menu.transform.position = player.position + new Vector3(player.forward.x, 0, player.forward.z).normalized * distanciaJogador;
        }

        // Faz o menu olhar (rotacionar) para o jogador
        menu.transform.LookAt(new Vector3(player.position.x, menu.transform.position.y, player.position.z));
        menu.transform.forward *= -1;
    }
}
