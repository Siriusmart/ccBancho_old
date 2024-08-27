using System;
using MCGalaxy;
using MCGalaxy.Events.PlayerEvents;

public class BanchoBot : Plugin {
    static Player Bancho = new Player("BanchoBot");

    public override string creator {
        get { return "siriusmart"; }
    }
    public override string name {
        get { return "BanchoBot"; }
    }

    public override string welcome {
        get { return "BanchoBot is now online!"; }
    }

    public override int build {
        get { return 0; }
    }

    public override void Load(bool startup) {
        OnPlayerChatEvent.Register(OnPlayerChat.Command, Priority.Low);
    }

    public override void Unload(bool shutdown) {
        OnPlayerChatEvent.Unregister(OnPlayerChat.Command);
    }
}
