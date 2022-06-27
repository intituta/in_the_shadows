using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inside_Colider : MonoBehaviour {


public GameObject coll_o;

public GameObject tri_o;


Collider coll;
Mesh trig_mesh;
Vector3[] vertices;

public bool inside = false;

public void Start()
{
	trig_mesh =  tri_o.GetComponent<MeshFilter>().mesh;
	vertices = trig_mesh.vertices;
	coll = coll_o.GetComponent<MeshCollider>();
}

public void Update()
{
	
	foreach(Vector3 tmp  in vertices)
	{
		Vector3 p = tri_o.transform.TransformPoint(tmp);
			Debug.DrawLine(p,Vector3.zero);
			Vector3 plop = coll.transform.TransformPoint( coll.GetComponent<MeshFilter>().mesh.vertices[0]);
			Debug.DrawLine(plop,Vector3.zero,Color.yellow);

		if(coll.bounds.Contains(p) == false)
		{
			inside =  false;
			return;
		}
	}
	inside =  true;
}

}
