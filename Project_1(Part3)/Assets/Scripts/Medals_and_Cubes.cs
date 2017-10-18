using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medals_and_Cubes : MonoBehaviour {

	int silver; 
	int bronze;
	int miningSpeed;
	int TimetoMine;
	int bronzeSupply;
	int silverSupply;
	int Xposition;
	public GameObject cube;

	// Use this for initialization
	void Start () {

	Xposition = 0;

	miningSpeed = 3;

	silver = 0;

	bronze = 0;
	
	bronzeSupply = 3;

	silverSupply = 2;

	TimetoMine = miningSpeed;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= TimetoMine) {

			TimetoMine = TimetoMine + miningSpeed;


			if (bronzeSupply > 0){

				bronze = bronze + 1;

				bronzeSupply = bronzeSupply - 1;

				print (bronze + " bronze");

				Xposition = Xposition + 2;

				var mycube = Instantiate (cube, new Vector3 (Xposition,0), Quaternion.identity);

				mycube.GetComponent<Renderer> ().material.color = Color.red;
			 }

			else if (bronzeSupply == 0){

				if (silverSupply > 0) {
					
					
					silver = silver + 1;

					silverSupply = silverSupply -1 ;

					print (silver + "silver");

					Xposition = Xposition +2 ; 

					var mycube = Instantiate (cube, new Vector3 (Xposition, 0), Quaternion.identity);
					mycube.GetComponent<Renderer> ().material.color = Color.white;
									  }
				}

		    }

		
				   }

}
