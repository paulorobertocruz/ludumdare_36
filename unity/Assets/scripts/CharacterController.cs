using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	int hp;
	public int max_hp = 0;

	int sanidade;
	public int max_sanidade = 0;
	bool safe_sanidade = false;

	int calor_corporal;
	public int max_calor_corporal = 0;
	bool safe_calor_corporal = false;



	// Use this for initialization
	void Start () {
		hp = max_hp;

		//começa com a metade da sanidade maxima
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

	void OnCollisionEnter(Collision collision){
		//entra na zona
		collision.collider.tag == "";
		if (collision.gameObject.CompareTag("safe_zone_calor")) {
			
		}
		else if(collision.gameObject.CompareTag("safe_zone_sanidade")){


		}
		
	}

	void OnCollisionExit(Collision collision){
		//sai da zona

		collision.collider.tag == "";
		if (collision.gameObject.CompareTag("safe_zone_calor")) {

		}
		else if(collision.gameObject.CompareTag("safe_zone_sanidade")){


		}
	}
}
