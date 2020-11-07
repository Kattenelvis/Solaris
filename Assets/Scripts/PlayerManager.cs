using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    public List<Player> players;
    public Player currentlyPlayingAs;
    public void generatePlayers(List<IRegion> regions)
    {
        players = new List<Player>{
        new Player(Player.controlledBy.NOONE, "Uncolonized"),
        new Player(Player.controlledBy.HUMAN, "European Union"),
        new Player(Player.controlledBy.AI, "East Leauge"),
        new Player(Player.controlledBy.AI, "American Empire")
        };

        Annex(players[1], regions[0]);
        Annex(players[2], regions[1]);
        Annex(players[2], regions[2]);
        Annex(players[3], regions[3]);

        currentlyPlayingAs = players[2];
    }
    [SerializeField] UI ui;
    public void Annex(Player newOwner, IRegion region)
    {
        if (region.owner != newOwner)
        {
            region.owner.regionsControlled.Remove(region);
            region.owner = newOwner;
            newOwner.regionsControlled.Add(region);
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
