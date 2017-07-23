using UnityEngine;
using System.Collections;

public class PlaneCreate : MonoBehaviour 
{
	private int PathSerialNo;
	public Transform CurrentPath;

	private Rigidbody NewPath;

	private Collider Other;

	public Rigidbody Path1;
	public Rigidbody Path2;
	public Rigidbody Path3;
	public Rigidbody Path4;
	public Rigidbody Path5;
	public Rigidbody Path6;
	public Rigidbody Path7;
	public Rigidbody Path8;
	public Rigidbody Path9;





	void OnTriggerEnter(Collider other)
	{
				if (other.gameObject.tag == "Path") {
						Destroy (other.gameObject);
						RandomPathInstantiate ();
				}
		}



	void RandomPathInstantiate() 
	{
		if(!ObstaclesCollide.Jetpack)
		Stamina.stam -= 5;

		PathSerialNo = Random.Range (1,9);
 	    switch (PathSerialNo)
		{

		case 1 : NewPath = Path1; break;

		case 2 : NewPath = Path2; break;

		case 3 : NewPath = Path3; break;

		case 4 : NewPath = Path4; break;

		case 5 : NewPath = Path5; break;

		case 6 : NewPath = Path6; break;

		case 7 : NewPath = Path7; break;

		case 8 : NewPath = Path8; break;

		case 9 : NewPath = Path9; break;

		}

		Object newPath;
		newPath = Instantiate( NewPath, new Vector3(0, 0, 750), CurrentPath.rotation);


	}





}
