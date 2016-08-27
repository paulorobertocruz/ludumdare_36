using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	int hp;
	public int max_hp = 0;

	int sanidade;
	public int max_sanidade = 0;

	int calor_corporal;
	public int max_calor_corporal = 0;

	// Use this for initialization
	void Start () {
		hp = max_hp;

		//
		sanidade = max_sanidade / 2;

		//começa com 10% do calor corporal maximo
		calor_corporal = max_calor_corporal / 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateCalorCorporal(){
		
	}

	void UpdateSanidade(){
		
	}

	void UpdateHp(){
		
	}
}
