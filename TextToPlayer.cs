using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextToPlayer : MonoBehaviour
{
   public TextMeshProUGUI playerText;
   
   public bool doesNotHaveRedKey = true;

   void OnTriggerEnter(Collider other)
   {
		  if(other.gameObject.CompareTag("redKey"))
		  {
				doesNotHaveRedKey = false;
				playerText.text = "You have picked up red key";
		  }
		  if(other.gameObject.CompareTag("RedDoor"))
		  {
				if(doesNotHaveRedKey == true)
				{
					playerText.text = "You need a red key for this!";
				}
		  }
   }
   void OnTriggerExit(Collider other)
   {
		  playerText.text = "";
   }
}
