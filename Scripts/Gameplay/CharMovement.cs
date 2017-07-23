using UnityEngine;
using System.Collections;

public class CharMovement: MonoBehaviour 
{
	private float HorMovement;
	private Collider Other;
	private Vector3 Position1;
	private Vector3 Position2;
	private int touchcount;
	private Vector2 initTouchPos;
	public static int jumpVar;
	int fingercount=0;	
	public static bool jumping;
	public static bool Touching;
	private Vector3 pos;

	void Start()
	{
		jumpVar = 5;
		jumping = false;
		Touching = false;
		}

	void Update()
	{

	if (PlaneMotion.GameOn) {
			
			if(!Touching){
				
				if(transform.position.x != -6 && transform.position.x <-4)
				{ 	
					pos = transform.position;
					pos.x = -6;
					transform.position=Vector3.MoveTowards(transform.position, pos, 1);
				}
				
				
				if(transform.position.x >-4 && transform.position.x != -2 && transform.position.x < 0)
				{ 	
					pos = transform.position;
					pos.x = -2;
					transform.position=Vector3.MoveTowards(transform.position, pos, 1);
				}
				
				
			
				
				
				if(transform.position.x >0 && transform.position.x != 2 && transform.position.x < 4)
				{ 	
					pos = transform.position;
					pos.x = 2;
					transform.position=Vector3.MoveTowards(transform.position, pos, 1);
				}
				
				
			
				
				if(transform.position.x >4 && transform.position.x != 6)
				{ 	
					pos = transform.position;
					pos.x = 6;
					transform.position=Vector3.MoveTowards(transform.position, pos, 1);
				}
				
			}

	
						Position1 = transform.position;
						Position2 = Position1;
						foreach (Touch touch in Input.touches) {
								if (touch.phase == TouchPhase.Began) {
										initTouchPos = touch.position;
										Touching = true;
								}

								if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
										fingercount++;
										Touching = false;
								}

								if (fingercount == 1 && touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Ended) {
										Vector2 touchFacing = (initTouchPos - touch.position).normalized;

					if (Vector2.Dot (touchFacing, -Vector2.right) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 70 && transform.position.x !=6) {
											Position2.x += 4;
												transform.position = Vector3.Lerp (Position1, Position2, 1f);
												fingercount = 0;
																			

										}

					if (Vector2.Dot (touchFacing, Vector2.right) > 0.8 && Vector2.Distance (initTouchPos, touch.position) > 70 && transform.position.x !=-6 ) {
																			
												Position2.x += -4;
												transform.position = Vector3.Lerp (Position1, Position2, 1f);	
												fingercount = 0;
																		

										}

					if (Vector2.Dot (touchFacing, -Vector2.up) > 0.6 && Vector2.Distance (initTouchPos, touch.position) > 50) {
						if (AvoidDoubleJump.CollisionTrue && !ObstaclesCollide.Jetpack) {
							if(jumpVar <= 5)
								jumping = true;

							
							AvoidDoubleJump.CollisionTrue = false;
							Position2.y += jumpVar;
							transform.position = Vector3.Lerp (Position1, Position2, PlaneMotion.PlaneSpeed);
							fingercount = 0;
						
							
						}
					}

								}
						}
						
		


					
				}
	
	}}
	