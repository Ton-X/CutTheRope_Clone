using UnityEngine;

public class Rope : MonoBehaviour {

	public Rigidbody2D hook;
	public GameObject linkPrefab;
	public int links = 7;
	public Weight weight;

	void Start () {
		GenerateRope();
	}
	
	void GenerateRope() {
		Rigidbody2D previousRB = hook;

		GameObject link;
		HingeJoint2D joint;
		for (int i = 0; i < links; i++) {
			link = Instantiate(linkPrefab, transform);
			joint = link.GetComponent<HingeJoint2D>();
			joint.connectedBody = previousRB;

			if (i < links - 1) {
				previousRB = link.GetComponent<Rigidbody2D>();
			} else {
				weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
			}

		}
	}
}
