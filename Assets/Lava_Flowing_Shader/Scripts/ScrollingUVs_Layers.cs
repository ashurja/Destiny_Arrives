using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour 
{
	//public int materialIndex = 0;
	public Vector3 uvAnimationRate = new Vector3( 1.0f, 0.0f, 0.0f );
	public string textureName = "_MainTex";

	private Vector3 startPosition; 
	Vector3 uvOffset = Vector3.zero;


	void LateUpdate() 
	{
		uvOffset += ( uvAnimationRate * Time.deltaTime );
		if( GetComponent<Renderer>().enabled )
		{
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset( textureName, uvOffset );
		}
	}
}