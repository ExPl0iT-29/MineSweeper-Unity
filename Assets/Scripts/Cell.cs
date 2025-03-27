using UnityEngine;

public struct Cell {
    public enum Type {  // Types of Cell
        Invalid,
        Empty,
        Mined,
        Number,
    }

    public Vector3Int position; // Vector3Int is used when working with tilemaps
    public Type type;
    public int number;
    public bool revealed;
    public bool flagged;
    public bool exploded;
}
