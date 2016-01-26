using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
	private List<GameObject> players;
	private List<bool> blockedPlayers;

	public GameObject npcPrefab;

	void Start()
	{
		players = new List<GameObject>();
		blockedPlayers = new List<bool>();
	}

	public void SpawnNPC(Vector3 position)
	{
		Instantiate(npcPrefab, position, Quaternion.identity);
	}

	public void AddPlayer(GameObject player)
	{
		players.Add(player);
		blockedPlayers.Add(false);
	}
}
