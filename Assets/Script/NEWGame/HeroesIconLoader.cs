using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class HeroesIconLoader : MonoBehaviour, IDataLoader<Character>
{
    [SerializeField] HeroIcon iconPrefab;
    [SerializeField] Character[] heroes;
    [HideInInspector]
    [SerializeField] List <HeroIcon> icons = new();

    [Button]
    public void LoadIcons()
    {
        foreach(var icon in icons)
        {
            if (icon != null)
                DestroyImmediate(icon.gameObject);
        }

        icons.Clear();

        foreach (var hero in heroes)
        { 
            HeroIcon icon = Instantiate(iconPrefab, transform);
            icons.Add(icon);
            (this as IDataLoader<Character>).LoadData(hero, icon);
        }
    }

}
