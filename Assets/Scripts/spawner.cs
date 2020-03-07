using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public GameObject Prefab;
	// Start is called before the first frame update
	//private GameObject Prefab2; 
	public float Int_to;
	public float Int_from;
	private float _timer;
	// Update is called once per frame
	private void FixedUpdate()
	{
		_timer -= Time.fixedDeltaTime;

		if (_timer > 0)
			return;

		_timer += Random.Range(Int_to, Int_from); ;
		var position = transform.position;
		position.z = 20;
		position.x += Random.Range(-380, 380);
		position.y += Random.Range(100, 250);
		Instantiate(Prefab, position, Quaternion.identity);
	}
}

