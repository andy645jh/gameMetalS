using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	private bool _pressLeft = false;
	private bool _pressRight = false;
	private bool _pressUp = false;
	private bool _pressDown = false;
	private bool _pressJump = false;
	private float _speed = 6.0F;
	private float _jumpSpeed = 8.0F;
	private float _gravity = 20.0F;
	private Vector3 _posGO = Vector3.zero;
	private CharacterController _controller;

	void Start () {
		_controller = GetComponent<CharacterController>();
	}	

	void Update () {

		// keys press
		/*if(Input.GetKeyDown(KeyCode.LeftArrow))
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

		if(Input.GetKeyUp(KeyCode.Space))
		{
			_pressJump = Input.GetKeyUp(KeyCode.Space);
		}

		// moving right or left
		if(_pressRight)
		{
			gameObject.transform.Translate(new Vector2(Time.deltaTime*2,0));
		}

		if(_pressLeft)
		{
			gameObject.transform.Translate(new Vector2(Time.deltaTime*-2,0));
		}*/


		_pressLeft = Input.GetKeyDown(KeyCode.LeftArrow);
		_pressRight = Input.GetKeyDown(KeyCode.RightArrow);
		_pressUp = Input.GetKeyDown(KeyCode.UpArrow);
		_pressDown = Input.GetKeyDown(KeyCode.DownArrow);
		
		/*_pressLeft = Input.GetKeyUp(KeyCode.LeftArrow);
		_pressRight = Input.GetKeyUp(KeyCode.RightArrow);
		_pressUp = Input.GetKeyUp(KeyCode.UpArrow);	
		_pressDown = Input.GetKeyUp(KeyCode.DownArrow);	*/
		_pressJump = Input.GetKeyUp(KeyCode.Space);

		// Salto
		if(_controller.isGrounded)
		{
			Debug.Log("Colisionando");
			_posGO = new Vector3(Input.GetAxis("Horizontal"), 0,0);
			_posGO = transform.TransformDirection(_posGO);
			_posGO *= _speed;
			if(_pressJump)
			{
				_posGO.y = _jumpSpeed;
			}
		}
		_posGO.y -= _gravity* Time.deltaTime;
		_controller.Move(_posGO*Time.deltaTime);
	}


}
