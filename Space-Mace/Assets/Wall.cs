using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Wall : Component
    {

        public Wall()
            {
                mass = 1;
                
            }


       public override void TileSet(Vector3Int clickCellPosition)
       {
           Ship.map.SetTile(clickCellPosition, texture);
       }
    }
