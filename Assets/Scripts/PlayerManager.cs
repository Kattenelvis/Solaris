using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager : MonoBehaviour
{
    public List<Player> players = new List<Player>{
        new Player(Player.controlledBy.NOONE, "Uncolonized"),
        new Player(Player.controlledBy.HUMAN, "Human Player"),
        new Player(Player.controlledBy.AI, "Enemy Player")
    };


    [SerializeField] UI ui;
    public void Annex(Player newOwner, IRegion region)
    {
        region.owner = newOwner;
        ui.updateUI();
    }
}
