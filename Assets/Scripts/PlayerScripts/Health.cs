//Skriven av Johnathan, redigerad av Daniel
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public int health;
	public int currentHealth; //Jag gjorde att currentHealth variabeln exklusivt anv�ndes ist�llet f�r en blandning av health och currentHealth. Tog bort �ven n�gra rader kod som st�llde till med problem i private void OnTriggerEnter2d. - Daniel
	public int maxHealth;
	public HealthBar HealthBar;
	//PlayerInvul invul;

	public AudioClip PlayerDamage;

	private void Start()
	{
		HealthBar.SetMaxHealth(maxHealth);
		maxHealth = currentHealth;
		//invul = GetComponent<PlayerInvul>();
	}

    private void Update()
    {
		health = currentHealth;
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
		if (currentHealth > 0)
		{
			//invul.gotHit = true;
			//Camera.main.GetComponent<AudioSource>().PlayOneShot(PlayerDamage);
			Debug.Log("Health = " + currentHealth.ToString());
			print("krembal");
		}
		if (currentHealth == 0)
		{
			SceneManager.LoadScene("GameOverScene");
		}

	}
}