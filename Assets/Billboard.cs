using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

	public Camera m_Camera;

	void Start()
	{
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		if (renderer) {
			//renderer.sortingLayerName = "Z";
			//renderer.sortingOrder = (int)transform.position.z;
		}
	}

	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
		                 m_Camera.transform.rotation * Vector3.up);
	}
}
