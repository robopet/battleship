using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

public class LoadMap : MonoBehaviour {
    public GameObject _shipPrefab;

    void Start() {
        //_shipPrefab = new GameObject("Ship");
        _shipPrefab.renderer.material.color = Color.green;
        //this.collider.bounds.min
        var point = collider.bounds.min;
        point.y = 2;
        point.z += 1;

        //var point = new Vector3(transform.position.x, 3, transform.position.z);
        //Debug.Log(string.Format("x - {0}, z - {1}", point.x, point.z));
        //Debug.Log(string.Format("Size.x = {0}, Size.z = {1}", collider.bounds.size.z, collider.bounds.size.z));
        //Debug.Log(string.Format("Min.x = {0}, Min.z = {1}", collider.bounds.min.x, collider.bounds.min.z));

        for (int i = 0; i < 9; i++) {
            //Debug.Log(string.Format("bounds.size.x = {0}", _shipPrefab.collider.bounds.size.x));
            //point.x += _shipPrefab.collider.bounds.size.x;
            //point.z += _shipPrefab.transform.localScale.z;
            //Debug.Log(string.Format("x - {0}, z - {1}", point.x, point.z));
            var v = new Vector3(point.x + 1, point.y, point.z);
            var obj = (GameObject)Instantiate(_shipPrefab, v, Quaternion.identity);

            // Debug.Log(string.Format("bounds.size.x = {0}", obj.collider.bounds.size.x));
            //point.x += obj.collider.bounds.min.x;
            //Debug.Log(string.Format("obj.collider.bounds.min.x = {0}", obj.collider.bounds.min.x));
            //Debug.Log(string.Format("i = {0}", i));
            //Debug.Log(string.Format("obj.collider.bounds.size.x = {0}", obj.collider.bounds.size.x));
            //point.x += i;
            //var v = new Vector3(point.x + 1, point.y, point.z);
            //obj.transform.position = v;
            point.x += 1;
            //obj.renderer.material.color = new Color(0.5f-i, 1+i, 1+i);
            //_shipPrefab.transform.position.x += _shipPrefab.collider.bounds.size.x;

        }
    }

    // Update is called once per frame
    void Update() {

    }
}
