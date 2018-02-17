using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

	public Transform[] posicoes;
	float direcao_x;
	float posicaoInicial_x, posicaoFinal_x;
	int posicaoAtual = 1;
	public float velocidade = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Fire1 = Clique do mouse, touch ou ctrl esq
		if (Input.GetButtonDown ("Fire1")) {
			posicaoInicial_x = Input.mousePosition.x;				
		} else if (Input.GetButtonUp ("Fire1")) {
			posicaoFinal_x = Input.mousePosition.x;	
			direcao_x = posicaoFinal_x - posicaoInicial_x;

			if (direcao_x > 0 && posicaoAtual <2) {
				posicaoAtual++;
			} else if (direcao_x <0 && posicaoAtual >0) {
				posicaoAtual--; 
			}
		}

		// Desloca o cubo para a pista atual
		transform.position = Vector3.Lerp(transform.position, posicoes[posicaoAtual].position, velocidade * Time.deltaTime);
	
	}


}
