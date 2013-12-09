using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	private bool _pressLeft = false;
	private bool _pressRight = false;
	private bool _pressUp = false;
	private bool _pressDown = false;


	// Use this for initialization
	void Start () {

	}	

	void Update () {

		// keys press
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			_pressLeft = true;
		}

		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			_pressRight = true;
		}

		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			_pressUp = true;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			_pressDown = true;
		}

		// keys releases
		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			_pressLeft = false;
		}
		
		if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			_pressRight = false;
		}
		
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			_pressUp = false;
		}
		
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			_pressDown = false;
		}

		// moving right or left
		if(_pressRight)
		{
			gameObject.transform.Translate(new Vector2(Time.deltaTime*2,0));
		}

		if(_pressLeft)
		{
			gameObject.transform.Translate(new Vector2(Time.deltaTime*-2,0));
		}

		//
	}


}
