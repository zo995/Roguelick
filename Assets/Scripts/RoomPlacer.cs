using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomPlace : MonoBehaviour
{
    public Room[] roomPrefabs;
    public Room startingRoom;

    private Room[,] spawnedRooms;

    void Start()
    {
        spawnedRooms = new Room[11, 11];
        spawnedRooms[5, 5] = startingRoom;

        for (int i = 0; i < 12; i++)
        {
            PlaceOneRoom();
        }
    }

    private void PlaceOneRoom()
    {
        HashSet<Vector2Int> vacantPlace = new HashSet<Vector2Int>();

        for (int x = 0; x < spawnedRooms.GetLength(0); x++)
        {
            for (int z = 0; z < spawnedRooms.GetLength(1); z++)
            {
                if (spawnedRooms[x, z] == null) continue;

                int maxX = spawnedRooms.GetLength(0) - 1;
                int maxZ = spawnedRooms.GetLength(1) - 1;

                if (x > 0 && spawnedRooms[x - 1, z] == null) vacantPlace.Add(new Vector2Int(x - 1, z));
                if (z > 0 && spawnedRooms[x, z - 1] == null) vacantPlace.Add(new Vector2Int(x, z - 1));
                if (x < maxX && spawnedRooms[x + 1, z] == null) vacantPlace.Add(new Vector2Int(x + 1, z));
                if (z < maxZ && spawnedRooms[x, z + 1] == null) vacantPlace.Add(new Vector2Int(x, z + 1));
            }
        }

        Room newRoom = Instantiate(roomPrefabs[Random.Range(0, roomPrefabs.Length)]);
        Vector2Int position = vacantPlace.ElementAt(Random.Range(0, vacantPlace.Count));
        newRoom.transform.position = new Vector3(position.x - 5, 0, position.y - 5) * 23;

        spawnedRooms[position.x, position.y] = newRoom;
    }
}
