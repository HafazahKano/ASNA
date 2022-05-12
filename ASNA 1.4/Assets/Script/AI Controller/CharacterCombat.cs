using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStat))]
public class CharacterCombat : MonoBehaviour
{

	public float attackSpeed = 1f;
	private float attackCooldown = 2f;

	public float attackDelay = .6f;

	public event System.Action OnAttack;

	CharacterStat myStats;

	void Start()
	{
		myStats = GetComponent<CharacterStat>();
	}

	void Update()
	{
		attackCooldown -= Time.deltaTime;
	}

	public void Attack(CharacterStat targetStats)
	{
		if (attackCooldown <= 0f)
		{
			StartCoroutine(DoDamage(targetStats, attackDelay));

			if (OnAttack != null)
				OnAttack();

			attackCooldown = 1f / attackSpeed;
		}

	}

	IEnumerator DoDamage(CharacterStat stats, float delay)
	{
		yield return new WaitForSeconds(delay);

		stats.TakeDamage(myStats.damage.GetValue());
	}

}