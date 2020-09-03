using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Tank : Component
{
    //var gasList = new List<Gas>();
    public Tank()
    {
        mass = 2;
    }

    
   public override void TileSet(Vector3Int clickCellPosition)
   {
       Ship.map.SetTile(clickCellPosition, texture);
   }

}



class Gas
{
    string name;
    int amount;
    int temperature;
}