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
        currentlyPlayingAs = players[1];
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
}
