using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
   public GameObject player;
   public Vector3Data value; 


   public void TeleportObjPosition(GameObject value)
   {
      if(player.GetComponent<CharacterController>())

      {
         CharacterController cc = player.GetComponent<CharacterController>();

         cc.enabled = false;

         player.transform.position = value.transform.position;

         cc.enabled = true; 
      }

      else
      {
         player.transform.position = value.transform.position; 
      }
   }
}
