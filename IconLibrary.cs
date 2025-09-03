using System.Collections.Generic;
using UnityEngine;

public class IconLibrary : MonoBehaviour
{
    public static IconLibrary instance;
    private Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();
    [Tooltip("Put the names of all of the spritesheets you want to load from the resources folder here, including any pathing that needs to occur"), SerializeField]
    private string[] spriteAtlasNames;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //for each defined spritesheet loop through every sprite and add it to the dictionary.
            foreach (string name in spriteAtlasNames)
            {
                Sprite[] atlas = Resources.LoadAll<Sprite>(name);
                for (int i = 0; i < atlas.Length; i++)
                {
                    sprites.Add(atlas[i].name, atlas[i]);
                }
            }
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    public Sprite GetIcon(string name)
    {
        return sprites[name];
    }

    public void SetIcon(string name, Sprite sprite)
    {
        sprites[name] = sprite;
    }

    public void AddIcon(string name, Sprite sprite)
    {
        sprites.Add(name, sprite);
    }

    public void RemoveIcon(string name)
    {
        sprites.Remove(name);
    }
}
