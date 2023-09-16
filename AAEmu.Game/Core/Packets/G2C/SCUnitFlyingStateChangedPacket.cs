using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C;

public class SCUnitFlyingStateChangedPacket : GamePacket
{
    private readonly uint _objId;
    private readonly bool _isFlying;

    public SCUnitFlyingStateChangedPacket(uint objId, bool isFlying) : base(SCOffsets.SCUnitFlyingStateChangedPacket, 1)
    {
        _objId = objId;
        _isFlying = isFlying;
    }

    public override PacketStream Write(PacketStream stream)
    {
        stream.WriteBc(_objId);
        stream.Write(_isFlying);
        return stream;
    }
}
