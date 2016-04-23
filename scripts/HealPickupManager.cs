using UnityEngine;
using System.Collections;

public class HealPickupManager : MonoBehaviour {
	public int x, y, z;
	public int healPoint = 20;
	PlayerHealth playerHealth;
	public GameObject player;
	
	void Awake ()
    {
        playerHealth = player.GetComponent <PlayerHealth> ();
    }
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("ok");
		playerHealth.TakeDamage (-healPoint);
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (x, y, z) * Time.deltaTime);
	}
}
