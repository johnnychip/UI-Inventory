using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioManager : MonoBehaviour {

	public Database myDatabase;
	public Image itemImage;
	public GameObject buttonPref;

	void Start (){

		for (int i = 0; i < myDatabase.items.Length; i++) {

			GameObject objTemp = Instantiate( buttonPref);
			objTemp.GetComponent<Buttons> ().Indice = i;
			objTemp.GetComponentInChildren<Text> ().text = myDatabase.items [i].itemName;
			objTemp.GetComponent<Buttons> ().MyManager = this;
			objTemp.transform.SetParent(transform);

		}

	}

	public void SetItemImage(int indice)
	{

		itemImage.sprite = myDatabase.items [indice].sprite;

	}
}
