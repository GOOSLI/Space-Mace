using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Ship : MonoBehaviour
{
    public TileBase TileToSet;
    static public Tilemap map;
    private Camera mainCamera;
    

    // Start is called before the first frame update
    void Start()
    {
        map = GetComponent<Tilemap>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 clickWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int clickCellPosition = map.WorldToCell(clickWorldPosition);          
            Debug.Log(clickCellPosition);
            map.SetTile(clickCellPosition, TileToSet);
            //Wall wall1 = new Wall();
            //Wall wall1 = gameObject.AddComponent<Wall>();
            //wall1.TileSet(clickCellPosition);
            
            
        }
    }
}
