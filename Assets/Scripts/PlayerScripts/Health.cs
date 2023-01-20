using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public int health;
	public int maxHealth = 3;
	public HealthBar HealthBar;
	public int currentHealth;
	//PlayerInvul invul;

	public AudioClip PlayerDamage;

	private void Start()
	{
		HealthBar.SetMaxHealth(maxHealth);
		maxHealth = health;
		//invul = GetComponent<PlayerInvul>();
	}
	
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		HealthBar.SetHealth(currentHealth);
	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
		print ("balls");
		if (collision.gameObject.CompareTag("Enemy"))
		{
			currentHealth--;
			//TakeDamage(1);
			print("benis");
		}
		if (health > 0)
		{
			health -= 1;
			//invul.gotHit = true;
			Camera.main.GetComponent<AudioSource>().PlayOneShot(PlayerDamage);
			Debug.Log("Health = " + health.ToString());
			print("krembal");
		}
		if (health == 0)
		{
			//SceneManager.LoadScene("DeathScene");
		}
	}
}