using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DoorController : Interactable
{
	public int keyId = 1;
	Inventory inventory;
	void Start()
	{
		inventory = Inventory.instance;
	}
	public override void Interact()
	{
		base.Interact();
		openDoor();
	}
	void openDoor() {
		foreach (Item item in inventory.items) {
			if(item.type == keyId)
			{
				Destroy(gameObject);
				Inventory.instance.Remove(item);
				break;
			}
		}
	}
}
