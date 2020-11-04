using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    public List<Player> players = new List<Player>{
        new Player(Player.controlledBy.NOONE, "Uncolonized"),
        new Player(Player.controlledBy.HUMAN, "European Union"),
        new Player(Player.controlledBy.AI, "East Leauge"),
        new Player(Player.controlledBy.AI, "American Empire")
    };
    public Player currentlyPlayingAs;

    private void OnEnable()
    {
        currentlyPlayingAs = players[2];
    }

    [SerializeField] UI ui;
    public void Annex(Player newOwner, Region region)
    {
        if (region.owner != newOwner)
        {
            region.owner = newOwner;

        }
    }
    public void ChangePlayer(Player newPlayer)
    {
        currentlyPlayingAs = newPlayer;
    }

    public Player findPlayerByTag(string tag)
    {
        foreach (Player player in players)
        {
            if (player.tag == tag)
                return player;
        }
        Debug.LogWarning("No tag was found");
        return null;
    }
}
