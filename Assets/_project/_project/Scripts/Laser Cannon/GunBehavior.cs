using UnityEngine;
using System.Collections;

public class GunBehavior : MonoBehaviour {

	public Transform m_Left_Blaster_Rotation;
	public Transform m_Left_Blaster_Position;
    public Transform m_Right_Blaster_Rotation;
	public Transform m_Right_Blaster_Position;
	public GameObject m_Laser_Object;
	public bool left = true;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		// Shooting left blaster
		if (Input.GetKeyDown(KeyCode.Space) && left == true)
		{
			GameObject go = GameObject.Instantiate(m_Laser_Object, m_Left_Blaster_Position, m_Left_Blaster_Rotation) as GameObject;
			GameObject.Destroy(go, 3f);
			left = false;
		}

		// Shooting right blaster
		if (Input.GetKeyDown(KeyCode.Space) && left == false)
		{
			GameObject go = GameObject.Instantiate(m_Laser_Object, m_Right_Blaster_Position, m_Right_Blaster_Rotation) as GameObject;
			GameObject.Destroy(go, 3f);
			left = true;
		}
	}
}

