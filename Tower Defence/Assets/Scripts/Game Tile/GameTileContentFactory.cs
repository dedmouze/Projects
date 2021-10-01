using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameTileContentFactory : GameObjectFactory
{
    [SerializeField] private GameTileContent _destinationPrefab;
    [SerializeField] private GameTileContent _emptyPrefab;
    [SerializeField] private GameTileContent _wallPrefab;
    [SerializeField] private GameTileContent _spawnPointPrefab;
    [SerializeField] private Tower[] _towerPrefabs;

    public void Reclaim(GameTileContent content)
    {
        Debug.Assert(content.OriginFactory == this, "Wrong factory reclaimed!");
        Destroy(content.gameObject);
    }
    public GameTileContent Get(GameTileContentType type)
    {
        switch (type)
        {   
            case GameTileContentType.Destination: return Get(_destinationPrefab);
            case GameTileContentType.Empty: return Get(_emptyPrefab);
            case GameTileContentType.Wall: return Get(_wallPrefab);
            case GameTileContentType.SpawnPoint: return Get(_spawnPointPrefab);
        }
        Debug.LogError("Unsupported type: " + type);
        return null;
    }
    public GameTileContent Get(TowerType type)
    {
        Debug.Assert((int)type < _towerPrefabs.Length, "Unsupported tower type!");
        Tower prefab = _towerPrefabs[(int) type];
        Debug.Assert(type == prefab.TowerType, "Tower prefab at wrong index!");
        return Get(prefab);
    }
    
    private T Get<T>(T prefab) where T : GameTileContent
    {
        T instance = CreateGameObjectInstance(prefab);
        instance.OriginFactory = this;
        return instance;
    }
}
