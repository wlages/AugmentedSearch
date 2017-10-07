using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctreeManager : MonoBehaviour {

    BoundsOctree<GameObject> boundsTree;
    PointOctree<GameObject> pointTree;

    // Use this for initialization
    void Start () {
        // Initial size (metres), initial centre position, minimum node size (metres), looseness
        boundsTree = new BoundsOctree<GameObject>(15, this.transform.position, 1, 1.25f);
        // Initial size (metres), initial centre position, minimum node size (metres)
     //   pointTree = new PointOctree<GameObject>(15, MyContainer.position, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDrawGizmos()
    {
        if (boundsTree != null)
        {
            boundsTree.DrawAllBounds(); // Draw node boundaries
            boundsTree.DrawAllObjects(); // Draw object boundaries
            boundsTree.DrawCollisionChecks(); // Draw the last *numCollisionsToSave* collision check boundaries
        }

      //  pointTree.DrawAllBounds(); // Draw node boundaries
     //   pointTree.DrawAllObjects(); // Mark object positions
    }

}


