using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 8.8f;
	public float ZSize = 8.8f;
	public GameObject foodPrefab;
	public Vector3 curPos;
	public GameObject curFood;


	void AddNewFood()
	{
	    RandomPos();
	    curFood = GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject;
	}

	void RandomPos()
	{
        curPos = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
	    Collider[] check = Physics.OverlapSphere(curPos, 1f);
	    if (check.Length == 0)
	    {
	        RandomPos();
	    }
	}

	void Update()
	{
		if(!curFood)
		{
			AddNewFood();
		}
		else
		{
			return;
		}
	}
}
