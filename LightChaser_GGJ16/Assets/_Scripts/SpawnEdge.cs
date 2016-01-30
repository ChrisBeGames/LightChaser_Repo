using UnityEngine;
using System.Collections;

/**Lazy af. */
public class SpawnEdge : MonoBehaviour {

	public GameObject edgePrefab;
	public float prefabWidth, radiusToPopulate;

	void Start () {
//		for (int i = 0; i < (int)(Mathf.PI * 2 * radiusToPopulate / prefabWidth); i++) {
//			Instantiate(edgePrefab, new Vector3(
//		}
	
		float degreeOffset = 360.0f / (Mathf.PI * 2 * radiusToPopulate / prefabWidth);

		Vector3 tempPosition = Vector3.zero;

		for (float currentDegree = 0; currentDegree < 360; currentDegree += degreeOffset) {

			tempPosition.x= Mathf.Cos (currentDegree) * radiusToPopulate;
			tempPosition.z= Mathf.Sin (currentDegree) * radiusToPopulate;

			var tempObj = (GameObject)Instantiate (edgePrefab);
			tempObj.transform.position = tempPosition + transform.position;
			tempObj.transform.rotation = Quaternion.LookRotation(transform.position - tempObj.transform.position);
			tempObj.transform.SetParent (transform);
		}
	}
}
