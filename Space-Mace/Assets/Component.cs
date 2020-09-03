using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class Component : MonoBehaviour
    {
        public int mass;
        public TileBase texture;

        public abstract void TileSet(Vector3Int clickCellPosition);
    }
