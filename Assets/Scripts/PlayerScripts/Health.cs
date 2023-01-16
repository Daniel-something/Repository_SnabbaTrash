using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public int health;
	int maxHealth;
	//PlayerInvul invul;

	public AudioClip PlayerDamage;

	private void Start()
	{
		maxHealth = health;
		//invul = GetComponent<PlayerInvul>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (health > 0)
		{
			health -= 1;
			//invul.gotHit = true;
			Camera.main.GetComponent<AudioSource>().PlayOneShot(PlayerDamage);
			Debug.Log("Health = " + health.ToString());
		}
		if (health == 0)
		{
			//SceneManager.LoadScene("DeathScene");
		}
	}
}