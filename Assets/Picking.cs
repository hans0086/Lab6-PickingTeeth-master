using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {
	public Camera pickingCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) == true) {
			//Creates a ray that is cast from the mouse's position into the world
			Vector3 mousePosition = Input.mousePosition;
			Ray pickingRay = pickingCamera.ScreenPointToRay (mousePosition);
			RaycastHit hit;
			bool success = Physics.Raycast (pickingRay,out hit);
			if (success) {
				Debug.Log ("The name of the picked object is: " + hit.collider.gameObject);
				//if the game object is tagged as a "Tooth" destroy it
				if (hit.collider.gameObject.tag.Contains ("Tooth"))
					Destroy (hit.collider.gameObject);
				
			}
		}
	}
}
