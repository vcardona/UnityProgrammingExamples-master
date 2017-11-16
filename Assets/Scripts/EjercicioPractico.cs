using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPractico : MonoBehaviour 
{
    public int Width;
    public int Height;
    public GameObject PuzzlePiece;
    private GameObject[,] Grid;

	void Start () 
	{
        Grid = new GameObject[Width,Height];
        for(int x = 0; x < Width; x++)
        {
            for(int y = 0; y < Height; y++)
            {
                GameObject go = GameObject.Instantiate(PuzzlePiece) as GameObject;
                Vector3 position = new Vector3(x,y,0);
                go.transform.position = position;
                Grid[x, y] = go;
            }
        }
	}
	
}
