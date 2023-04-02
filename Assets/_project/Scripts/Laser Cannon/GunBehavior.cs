using UnityEngine;
using System.Collections;

public class GunBehavior : MonoBehaviour {

	public Transform m_blasterRotation;
	public Transform m_blasterPosition;
	public GameObject m_Laser_Object;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject go = GameObject.Instantiate(m_Laser_Object, m_blasterPosition, m_blasterRotation) as GameObject;
			GameObject.Destroy(go, 3f);
		}
	}
}
