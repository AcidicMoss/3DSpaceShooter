using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCam : MonoBehaviour
{
        public Camera firstPerson;
        public Camera thirdPerson;
 
 void Start() {
      firstPerson.enabled = true;
      thirdPerson.enabled = false;
 }
 
 void Update() {
    
    // Switches from cam0 to cam1
     if (Input.GetKeyDown(KeyCode.C)) {
        firstPerson.enabled = !firstPerson.enabled;
        thirdPerson.enabled = !thirdPerson.enabled;
     }
 }
}
